using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lustre : MonoBehaviour
{
    public static bool _active;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (_active)
        {
            rb.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GameController")
        {
            _active = true;
        }
    }

}
