using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour
{
    public Image GamePlay;
    public List<Sprite> ChangeBackGround;

    public static BackgroundChange inst;

    private void Awake()
    {
        inst = this;
    }

    public void ChangeBackground(int i)
    {
        GamePlay.sprite = ChangeBackGround[i];
    }
}

