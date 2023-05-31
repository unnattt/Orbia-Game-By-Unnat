using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {            
            ScreenManager.instance.ShowNextScreen(ScreenType.GameOverPage);
        }
    }
    private void Start()
    {
        
    }
}
