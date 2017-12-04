using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsThatFAll : MonoBehaviour
{
    public GameObject enemy;

    public void OnCollisionEnter(Collision collision)
    {
     //   Destroy(enemy.gameObject);
        DestroyImmediate(enemy.gameObject);
        print("hola");
    }
}
