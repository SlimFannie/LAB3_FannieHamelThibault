using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Final : MonoBehaviour
{
    private GestionJeu _gestionJeu = default;
    [SerializeField] private TMP_Text _temps = default;
    [SerializeField] private TMP_Text _accrochages = default;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();

        _temps.SetText(_gestionJeu.GetTempsNivTrois().ToString());

        _accrochages.SetText(_gestionJeu.CalculPointage().ToString());
    }

}
