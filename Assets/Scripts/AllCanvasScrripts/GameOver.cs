using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button MainMenuButton;
    public Button RestartGameButton;
    public GameController start;

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
        Time.timeScale = 1f;
        if (ScoreManager.instance.CurrentLevelCount.text == "1")
        {
            SaveManager.instance.LoadPlayerDataToLevel1();            
        }
        else if (ScoreManager.instance.CurrentLevelCount.text == "2")
        {
            SaveManager.instance.LoadPlayerDataToLevel2();
        }
        else if (ScoreManager.instance.CurrentLevelCount.text == "3")
        {
            SaveManager.instance.LoadPlayerDataToLevel3();       
        }
        else if (ScoreManager.instance.CurrentLevelCount.text == "4")
        {
            SaveManager.instance.LoadPlayerDataToLevel4();            
        }
        start.enabled = true;
        
    }
}
