using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GestionJeu : MonoBehaviour
{

    private int _murs;
    private int _obstacles;
    private int _pointage;

    private int counter = 0;

    private float _tempsNiveauUn = 0.0f;
    private float _tempsNiveauDeux = 0.0f;
    private float _tempsNiveauTrois = 0.0f;

    [SerializeField] private TMP_Text _temps = default;
    string temps;
    [SerializeField] private TMP_Text _accrochages = default;
    string accrochages;

    private void Awake()
    {  
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
            Destroy(_temps);
            Destroy(_accrochages);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(_temps);
            DontDestroyOnLoad(_accrochages);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true || Input.GetKeyDown(KeyCode.RightArrow) == true || Input.GetKeyDown(KeyCode.UpArrow) == true || Input.GetKeyDown(KeyCode.DownArrow) == true ||
        Input.GetKeyDown(KeyCode.W) == true || Input.GetKeyDown(KeyCode.A) == true || Input.GetKeyDown(KeyCode.S) == true || Input.GetKeyDown(KeyCode.D) == true)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
        if (noScene == 0)
        {
            Debug.Log("* Niveau 1: Zone militarisée *");
        }
        else if (noScene == 1)
        {
            Debug.Log("** Niveau 2: Zone de turbulence **");
        }
        else if (noScene == 2)
        {
            Debug.Log("*** Niveau 3: L'oeil de la tempête ***");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true || Input.GetKeyDown(KeyCode.RightArrow) == true || Input.GetKeyDown(KeyCode.UpArrow) == true || Input.GetKeyDown(KeyCode.DownArrow) == true ||
        Input.GetKeyDown(KeyCode.W) == true || Input.GetKeyDown(KeyCode.A) == true || Input.GetKeyDown(KeyCode.S) == true || Input.GetKeyDown(KeyCode.D) == true)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        int noScene = SceneManager.GetActiveScene().buildIndex;

        if (noScene == 1)
        {
            Debug.Log("* Niveau 1: Zone militarisée *");
            float myTime = Time.time;
            string timeText = System.TimeSpan.FromSeconds(myTime).ToString("mm':'ss");
            _temps.SetText(timeText);
            accrochages = (GetMurs() + GetObs()).ToString();
            _accrochages.SetText(accrochages);
        }
        else if (noScene == 2)
        {
            Debug.Log("** Niveau 2: Zone de turbulence **");
            float myTime = GetTempsNivUn();
            string timeText = System.TimeSpan.FromSeconds(myTime).ToString("mm':'ss");
            _temps.SetText(timeText);
            accrochages = (GetMurs() + GetObs()).ToString();
            _accrochages.SetText(accrochages);
        }
        else if (noScene == 3)
        {
            Debug.Log("*** Niveau 3: L'oeil de la tempête ***");
            float myTime = GetTempsNivDeux();
            string timeText = System.TimeSpan.FromSeconds(myTime).ToString("mm':'ss");
            _temps.SetText(timeText);
            accrochages = (GetMurs() + GetObs()).ToString();
            _accrochages.SetText(accrochages);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true || Input.GetKeyDown(KeyCode.RightArrow) == true || Input.GetKeyDown(KeyCode.UpArrow) == true || Input.GetKeyDown(KeyCode.DownArrow) == true ||
        Input.GetKeyDown(KeyCode.W) == true || Input.GetKeyDown(KeyCode.A) == true || Input.GetKeyDown(KeyCode.S) == true || Input.GetKeyDown(KeyCode.D) == true)
        {
            Time.timeScale = 1;
        }
    }

    public void MalusMurs()
    {
        _murs++;
    }

    public int GetMurs()
    {
        return _murs;
    }

    public void MalusObs()
    {
        _obstacles++;
    }

    public int GetObs()
    {
        return _obstacles;
    }

    public int CalculPointage()
    {
        return _pointage = (GetMurs() * 2) + GetObs();
    }

    public float GetTempsNivUn()
    {
        return _tempsNiveauUn;
    }

    public float GetTempsNivDeux()
    {
        return _tempsNiveauDeux;
    }

    public float GetTempsNivTrois()
    {
        return _tempsNiveauTrois;
    }

    public float GetTemps()
    {
        return GetTempsNivUn() + GetTempsNivDeux() + GetTempsNivTrois();
    }

    public void SetNiveauUn(float tempsNivUn)
    {
        _tempsNiveauUn = tempsNivUn;
    }

    public void SetNiveauDeux(float tempsNivDeux)
    {
        _tempsNiveauDeux = tempsNivDeux;
    }

    public void SetNiveauTrois(float tempsNivTrois)
    {
        _tempsNiveauTrois = tempsNivTrois;
    }

    public void AugmenterCounter()
    {
        counter++;
    }

    public int GetCounter()
    {
        return counter;
    }

}
