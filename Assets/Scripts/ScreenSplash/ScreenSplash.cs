using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSplash : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(SplashScreen());
    }

    IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
    
}
