using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    int level1 = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SaveManager.instance.PlayerPos();
        ScoreManager.instance.CurrentLevelCount.text = level1.ToString();
        SaveManager.instance.CurrentLevelCount();
        BackgroundChange.inst.ChangeBackground(level1);
    }

    private void Start()
    { 
        ScoreManager.instance.CurrentLevelCount.text = level1.ToString();
    }

}
