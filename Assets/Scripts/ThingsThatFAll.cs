using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsThatFAll : MonoBehaviour {

    public GameObject chandelier, trigger;
    Rigidbody cndRb;
    private void Start() {
        cndRb = chandelier.GetComponent<Rigidbody>();
        cndRb.useGravity = false;
        //El set active y lo de la gravedad
    }
    public void OnTriggerEnter( Collider other ) {        
        cndRb.useGravity = true;
        trigger.SetActive(false);
    }
    public void OnCollisionEnter( Collision collision ) {
        print("Bjsdbsjbsb");
        //Posacabaeldestroydelositems, no uses el tag, solo coloca la funcion
    }
}
