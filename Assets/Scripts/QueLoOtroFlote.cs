using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueLoOtroFlote : MonoBehaviour {

    public static bool flota;
	// Use this for initialization
	void Start () {
        flota = false;	
	}

    private void OnTriggerEnter(Collider other)
    {
        flota = true;
    }
}
