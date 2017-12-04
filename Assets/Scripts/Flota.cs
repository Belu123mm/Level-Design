using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flota : MonoBehaviour
{
    public float degreesPerSecond = 15;
    public float amplitude = 0.5f;
    public float frecuency = 1;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    // Use this for initialization
    void Start()
    {
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (QueLoOtroFlote.flota)
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * degreesPerSecond, 0), Space.World);
            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frecuency) * amplitude;
            transform.position = tempPos;
        }
    }
}
