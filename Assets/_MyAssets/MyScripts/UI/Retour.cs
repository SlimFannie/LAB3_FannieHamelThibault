using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Retour : MonoBehaviour
{
    public void RetourMenu()
    {
        SceneManager.LoadScene("Depart");
    }
}
