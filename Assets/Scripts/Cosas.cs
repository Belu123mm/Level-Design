using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cosas : MonoBehaviour
{
    public void IrAJuego()
    {
        SceneManager.LoadScene("Level2");
    }
    public void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
