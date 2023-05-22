using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text CurrentLevelCount;
    public TMP_Text TotalCrystalCount;
    public TMP_Text LoadCurrentLevel;
    public TMP_Text LevelCountinMainMenu;
    public TMP_Text CrystalMainMenu;

    private int Score;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SaveManager.instance.CrystalLoadData();
    }

    public void score(int points)
    {
        Score += points;
        TotalCrystalCount.text = Score.ToString();
        CrystalMainMenu.text = Score.ToString();
    }

}
