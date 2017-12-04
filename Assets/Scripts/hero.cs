using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hero : MonoBehaviour
{
    public int life;
    public Text textLife;

    void Update()
    {
        textLife.text = "Life: " + life;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            life -= 20;
            textLife.text = "Life: " + life;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "room")
            SceneManager.LoadScene("Room");
    }
}
