using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreen : BaseScreen
{
    [SerializeField] Button PlayNowButton;
    [SerializeField] Button SettingButton;

    void Start()
    {
        SoundManager.inst.PlaySound(SoundManager.SoundName.GamePlaySound);
        PlayNowButton.onClick.AddListener(PlayNow);
        SettingButton.onClick.AddListener(SettingPop);
    }
    void PlayNow()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);

    }
    void SettingPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.SettingPage);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);

    }


}
