using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button MainMenuButton;
    public Button RestartGameButton;

    public static GameOver inst;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        MainMenuButton.onClick.AddListener(MainMenu);
        RestartGameButton.onClick.AddListener(RestartGame);
    }

    void MainMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
        SaveManager.instance.CrystalsaveData();
    }

    public void RestartGame()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);  
    }
}
