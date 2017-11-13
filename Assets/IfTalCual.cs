using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTalCual : MonoBehaviour {

    public GameObject button;
    public Rigidbody [] rbricks;
    public GameObject [] blocks = new GameObject [ 3 ];
        void Start() {
        this.GetComponent<Renderer>().enabled = false;
        rbricks = GetComponentsInChildren<Rigidbody>();
        foreach ( var rig in rbricks ) {
            rig.useGravity = false;
            rig.isKinematic = true;
        }
        foreach ( var bl in blocks ) {
            bl.GetComponent<Renderer>().enabled = false;
        }

    }

    private void OnTriggerEnter( Collider other ) {
        print("HI");
        foreach ( var rig in rbricks ) {
            rig.isKinematic = false;
            rig.useGravity = true;

        }
    }
}
