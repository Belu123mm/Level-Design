using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cosas : MonoBehaviour
{
    void IrAJuego()
    {
        SceneManager.LoadScene("Level2");
    }
    void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
