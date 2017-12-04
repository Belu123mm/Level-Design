using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemies : MonoBehaviour
{
    public float speed;

    public GameObject hero;
    public float viewAngle;
    public float viewDistance;

    private Vector3 dirHero;
    private float angleToHero;
    private float _distanceToHero;
    private bool _heroInSight;

    public List<Transform> point;
    int poitI;
    NavMeshAgent navEnemy;
    public GameObject pointsGroup;
    public float distance;

    public GameObject muerte;


    void Start()
    {
        if (pointsGroup.transform.childCount > 0)
        {
            for (int i = 0; i < pointsGroup.transform.childCount; i++)
                point.Add(pointsGroup.transform.GetChild(i));
        }
        navEnemy = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        HeroOnSight();
        if (!_heroInSight)
        {
            if (point != null && point.Count > 1)
            {
                if (navEnemy.remainingDistance < .5f)
                {
                    poitI++;
                    if (poitI >= point.Count)
                        poitI = 0;
                }
                navEnemy.SetDestination(point[poitI].position);
            }
        }
        if (_heroInSight)
            navEnemy.destination = hero.transform.position;
        else
            navEnemy.SetDestination(point[poitI].position);

    }

    void OnCollisionEnter(Collision c)
    {
        navEnemy.SetDestination(point[poitI].position);        
    }

    public void HeroOnSight()
    {
        dirHero = (hero.transform.position - transform.position).normalized;

        angleToHero = Vector3.Angle(transform.forward, dirHero);


        _distanceToHero = Vector3.Distance(transform.position, hero.transform.position);

        if (angleToHero <= viewAngle && _distanceToHero <= viewDistance)
        {
            RaycastHit rch;
            bool obstaclesBetween = false;

            if (Physics.Raycast(transform.position, dirHero, out rch, _distanceToHero))
                if (rch.collider.gameObject.layer == Layers.WALL)
                    obstaclesBetween = true;

            if (!obstaclesBetween)
                _heroInSight = true;
            else
                _heroInSight = false;
        }
        else
            _heroInSight = false;
    }    

    void OnDrawGizmos()
    {
        if (_heroInSight)
            Gizmos.color = Color.green;
        else
            Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, hero.transform.position);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, viewDistance);

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * viewDistance));

        Vector3 rightLimit = Quaternion.AngleAxis(viewAngle, transform.up) * transform.forward;
        Gizmos.DrawLine(transform.position, transform.position + (rightLimit * viewDistance));

        Vector3 leftLimit = Quaternion.AngleAxis(-viewAngle, transform.up) * transform.forward;
        Gizmos.DrawLine(transform.position, transform.position + (leftLimit * viewDistance));
    }
}
