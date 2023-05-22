using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllLevel : MonoBehaviour
{
    public GameController start;
    [SerializeField] Button Buttonback;

    private void Start()
    {
        Buttonback.onClick.AddListener(BackToMenu);
    }

    void BackToMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
        AudioManager.inst.PlayAudio(AudioManager.AudioName.BackButtonSound);
    }

    public void LoadLvlOne(int i)
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);
        SaveManager.instance.PlayerToLevel(i);
        start.enabled = true;
        Time.timeScale = 1f;
        AudioManager.inst.PlayAudio(AudioManager.AudioName.AllButtonSound);
    }
}
