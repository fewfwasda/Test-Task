using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public bool isstartMenu=true;
    public GameObject startMenuUI;
    private void Update()
    {
        if (isstartMenu == true)Menu();
        else ButtomToPlay();
    }

    public void ButtomToPlay()
    {
        startMenuUI.SetActive(false);
        Time.timeScale=1f;
    }
    public void Menu()
    {
        startMenuUI.SetActive(true);
        Time.timeScale=0f;
    }
}