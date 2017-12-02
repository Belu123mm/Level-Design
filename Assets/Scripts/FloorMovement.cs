using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float speed;
    public float dir = -1;

    void Update()
    {
        transform.position += new Vector3(0, 0, dir * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "1")
            dir = 1;
        if (c.gameObject.tag == "2")
            dir = -1;
    }
}
