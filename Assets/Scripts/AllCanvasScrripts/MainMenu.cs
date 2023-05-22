using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button LoadGameNowButton;
    [SerializeField] Button OptionsButton;
    [SerializeField] Button LevelsButton;
    [SerializeField] Button MainMenuButton;
    public GameController start;
    

    void Start()
    {
        LoadGameNowButton.onClick.AddListener(LoadCurrentLevel);
        OptionsButton.onClick.AddListener(OptionPop);
        LevelsButton.onClick.AddListener(LevelPop);
        MainMenuButton.onClick.AddListener(BackMainMenu);
    }
    private void Update()
    {
        SaveManager.instance.LoadLastLevelData();
    }

    void LoadCurrentLevel()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);
        start.enabled = true;
        if (ScoreManager.instance.LoadCurrentLevel.text == "1")
        {
            SaveManager.instance.LoadPlayerDataToLevel1();
        }
        else if (ScoreManager.instance.LoadCurrentLevel.text == "2")
        {
            SaveManager.instance.LoadPlayerDataToLevel2();
        }
        else if (ScoreManager.instance.LoadCurrentLevel.text == "3")
        {
            SaveManager.instance.LoadPlayerDataToLevel3();
        }
        else if (ScoreManager.instance.LoadCurrentLevel.text == "4")
        {
            SaveManager.instance.LoadPlayerDataToLevel4();
        }
        Time.timeScale = 1f;
    }

    void OptionPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.SettingPage);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);
    }

    void LevelPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.LevelSelectionPage);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);
    }

    void BackMainMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.HomeScreen);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.BackButtonSound);

    }
}
