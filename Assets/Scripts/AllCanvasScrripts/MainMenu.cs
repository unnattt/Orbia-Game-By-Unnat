using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : BaseScreen
{
    [SerializeField] Button LoadGameNowButton;
    [SerializeField] Button OptionsButton;
    [SerializeField] Button MainMenuButton;
    

    void Start()
    {
        LoadGameNowButton.onClick.AddListener(LoadCurrentLevel);
        OptionsButton.onClick.AddListener(OptionPop);        
        MainMenuButton.onClick.AddListener(BackMainMenu);
    }

    private void Update()
    {
        SaveManager.instance.LoadLastLevelData();
    }

    void LoadCurrentLevel()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);        
    }

    void OptionPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.SettingPage);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);
    }

    void BackMainMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.HomeScreen);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.BackButtonSound);

    }
}
