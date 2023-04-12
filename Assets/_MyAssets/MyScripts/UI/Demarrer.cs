using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demarrer : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Niveau1");
    }
    
}
