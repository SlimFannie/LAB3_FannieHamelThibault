using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{

    [SerializeField] public GameObject Pop;
    private bool Popped = false;

    // Update is called once per frame
    void Update()
    {
        Esc();
    }

    public void Open()
    {
        Pop.SetActive(true);
    }

    public void Close()
    {
        Pop.SetActive(false);
    }

    public void Esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Popped != true)
        {
            Pop.SetActive(true);
            Popped = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Popped == true)
        {
            Pop.SetActive(false);
            Popped = false;
            Time.timeScale = 1;
        }
    }

}
