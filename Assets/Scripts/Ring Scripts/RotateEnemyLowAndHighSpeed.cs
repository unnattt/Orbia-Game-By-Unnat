using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemyLowAndHighSpeed : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float max = 20f;
    public float min = 5f;


    private void Start()
    {
        StartCoroutine(Changespeed(min, max, 5f));
    }


    private void Update()
    {
        RotateEnemyOnRingOrbit();
    }

    public void RotateEnemyOnRingOrbit()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, speed * Time.deltaTime);
    }

    IEnumerator Changespeed(float startspeed, float endspeed, float duration)
    {
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            speed = Mathf.Lerp(startspeed, endspeed, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(Changespeed(endspeed, startspeed, 5f));
    }
}


