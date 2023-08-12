using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonController : MonoBehaviour
{

    public GameObject Mute;

    private void Start()
    {
        if (GameManager.mute)
        {
            Mute.SetActive(true);
        }
        MuteAintActive();

    }
    public void MuteAintActive()
    {
        Mute.SetActive(false);
    }
    public void ToggleMute()
    {
        if (GameManager.mute)
        {
            GameManager.mute = false;
            Mute.SetActive(true);
        }
        else
        {
            GameManager.mute = true;
            Mute.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Trrrr");
    }
}
