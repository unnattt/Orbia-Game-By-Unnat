using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScreen : MonoBehaviour
{
    [HideInInspector] public Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void ShowScreen()
    {
        canvas.enabled = true;
    }

    public void HideScreen()
    {
        canvas.enabled = false;
    }

}

public enum ScreenType
{
   HomeScreen,
   MainMenu,
   SettingPage,
   GameOverPage,
   GamePlayCanvas,

}