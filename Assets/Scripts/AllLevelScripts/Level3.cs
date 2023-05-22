using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    int level3 = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SaveManager.instance.PlayerPos();
        ScoreManager.instance.CurrentLevelCount.text = level3.ToString();
        SaveManager.instance.CurrentLevelCount();
        BackgroundChange.inst.ChangeBackground(level3);
    }
    private void Start()
    {
        ScoreManager.instance.CurrentLevelCount.text = level3.ToString();
    }

}
