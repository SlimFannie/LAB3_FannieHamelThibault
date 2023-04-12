using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDuJeu : MonoBehaviour
{

    private GestionJeu _gestionJeu;
    private Player _player;
    private int _pointage = 0;
    private bool _touche = false;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && !_touche)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            _gestionJeu.AugmenterCounter();
            _touche = true;
        }

        if (_gestionJeu.GetCounter() == 4)
        {
            _pointage += 30 - _gestionJeu.CalculPointage();
            _gestionJeu.SetNiveauTrois(_gestionJeu.GetTempsNivDeux() + Time.time);
            _player.gameObject.SetActive(false);
            SceneManager.LoadScene("Fin");
        }
    }
}
