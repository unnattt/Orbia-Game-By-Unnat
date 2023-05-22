using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : MonoBehaviour
{
    int level4 = 4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SaveManager.instance.PlayerPos();
        ScoreManager.instance.CurrentLevelCount.text = level4.ToString();
        SaveManager.instance.CurrentLevelCount();
        BackgroundChange.inst.ChangeBackground(level4);
    }
    private void Start()
    {
        ScoreManager.instance.CurrentLevelCount.text = level4.ToString();
    }

}
