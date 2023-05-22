using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameController stop;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ScreenManager.instance.ShowNextScreen(ScreenType.GameOverPage);
            Time.timeScale = 0f;
            stop.enabled = false;
        }
    }
    private void Start()
    {
        
    }
}
