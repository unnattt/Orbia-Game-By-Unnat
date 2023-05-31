using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setting : BaseScreen
{
    [SerializeField] Button backButton;
    [SerializeField] Button MusicOffBtn;
    [SerializeField] Button MusicOnBtn;
    [SerializeField] Button AudioOffButton;
    [SerializeField] Button AudioOnButton;
    [SerializeField] GameObject audioOn;
    [SerializeField] GameObject audioOff;
    [SerializeField] GameObject SOundOn;
    [SerializeField] GameObject SOundOff;

    private void Start()
    {
        backButton.onClick.AddListener(BacktoMenu);
        MusicOffBtn.onClick.AddListener(SoundOn);
        MusicOnBtn.onClick.AddListener(SoundOff);
        AudioOffButton.onClick.AddListener(AudioOn);
        AudioOnButton.onClick.AddListener(AudioOff);
    }

    public void BacktoMenu()
    {       
      ScreenManager.instance.ShowNextScreen(ScreenType.HomeScreen);
      AudioManager.inst.PlayAudio(AudioManager.AudioName.BackButtonSound);       
    }

    public void AudioOn()
    {
        audioOn.SetActive(true);
        audioOff.SetActive(false);
        AudioManager.inst.audioSource.mute = false;
        
    }

    public void AudioOff()
    {
        audioOn.SetActive(false);
        audioOff.SetActive(true);
        AudioManager.inst.audioSource.mute = true;
    }

    public void SoundOff()
    {
        SOundOff.SetActive(true);
        SOundOn.SetActive(false);
        SoundManager.inst.audioSource.Stop();
        
    }

    public void SoundOn()
    {
        SOundOff.SetActive(false);
        SOundOn.SetActive(true);
        SoundManager.inst.audioSource.Play(); 
    }




}
