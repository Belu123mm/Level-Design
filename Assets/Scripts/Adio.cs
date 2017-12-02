using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Adio : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("HI");
        SceneManager.LoadScene("GameOver");
    }
}
