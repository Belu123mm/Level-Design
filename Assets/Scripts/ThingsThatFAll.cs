using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsThatFAll : MonoBehaviour {

    public GameObject chandelier, trigger;
    Rigidbody cndRb;
    Light light;
    bool triggered;
    private void Start() {
        cndRb = chandelier.GetComponent<Rigidbody>();
        cndRb.useGravity = false;
        light = trigger.GetComponent<Light>();
        triggered = false;
        //El set active y lo de la gravedad
    }
    public void OnTriggerEnter( Collider other ) {        
        if ( !triggered ) {
        cndRb.useGravity = true;
        light.enabled = false;
            triggered = true;
        }
    }
    public void OnCollisionEnter( Collision collision ) {
        print("Bjsdbsjbsb");
        //Posacabaeldestroydelositems, no uses el tag, solo coloca la funcion
    }
}
