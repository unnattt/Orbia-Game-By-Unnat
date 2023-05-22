using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    int level2 = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SaveManager.instance.PlayerPos();
        ScoreManager.instance.CurrentLevelCount.text = level2.ToString();
        SaveManager.instance.CurrentLevelCount();
        BackgroundChange.inst.ChangeBackground(level2);
    }
    private void Start()
    {
        ScoreManager.instance.CurrentLevelCount.text = level2.ToString();
    }

}
