using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public static int score;
    public Text textScore;

    void Update()
    {
        textScore.text = "Score: " + score;
    }
    public void OnTriggerEnter(Collider other)
    {
        score += 10;
        textScore.text = "Score: " + score;
        this.gameObject.SetActive(false);
    }
}
