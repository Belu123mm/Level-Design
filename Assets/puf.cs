using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puf : MonoBehaviour
{
    public Mesh mesh;
    public Renderer rend;
    //public Collider c;
    public BoxCollider c;
    public float timer;
    // Use this for initialization
    void Start()
    {
        c = GetComponent<BoxCollider>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        c.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            c.enabled = false;
            rend.enabled = false;            
        }
        if (timer > 6)
        {
            c.enabled = true;
            rend.enabled = true;
            timer = 0;
        }
    }
}
