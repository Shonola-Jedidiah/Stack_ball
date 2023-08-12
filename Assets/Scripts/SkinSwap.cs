using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSwap : MonoBehaviour
{
    public GameObject[] Skins;
    private int SelectedSkin=0;

    void Start()
    {
        foreach (GameObject sk in Skins)
        {
            sk.SetActive(false);
        }
        Skins[SelectedSkin].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void skinSwap(int newSkin)
    {
        Skins[SelectedSkin].SetActive(false);
        Skins[newSkin].SetActive(true);
        SelectedSkin = newSkin;
    }
}
