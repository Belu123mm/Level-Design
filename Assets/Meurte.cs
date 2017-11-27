using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meurte : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "GameController")
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("cmurio");
        }
    }
}
