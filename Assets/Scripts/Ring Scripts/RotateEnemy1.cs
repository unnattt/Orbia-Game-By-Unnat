using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy1 : MonoBehaviour
{
    public GameObject target;
    public float _enemyAngle = 20f;
    public float radius;
    public float min ;
    public float max ;

    private void Start()
    {
        StartCoroutine(ChangeRadius(min, max, 5f));
    }

    private void Update()
    {
        ApplyRadius();
        RotateEnemyOnRingOrbit();
    }

    public void RotateEnemyOnRingOrbit()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, _enemyAngle * Time.deltaTime);
    }

    private void ApplyRadius()
    {
        // Get the direction vector from the pivot to your current object position
        Vector3 direction = (transform.position - target.transform.position).normalized;

        // set your object in the same direction but at distance of radius
        transform.position = target.transform.position + direction * radius;   
      
    }

    IEnumerator ChangeRadius(float startRadius, float endRadius, float duration)
    {
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            radius = Mathf.Lerp(startRadius, endRadius, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }   
        StartCoroutine(ChangeRadius(endRadius, startRadius, 5f));
    }
        //if (radius >= 0.8f)
        //{
        //    yield return new WaitForSeconds(2f);
        //    StartCoroutine(ChangeRadius(min, max, 10f));
        //    Debug.Log("Is Started");
        //}


        //radius = v_end;


    

    //public IEnumerator ChangeRadius2()
    //{

    //}
    //IEnumerator ChangeRadius2(float Max, float Min, float duration)
    //{
    //    float elapsed = 0.0f;
    //    while (elapsed < duration)
    //    {
    //        radius = Mathf.Lerp(Max, Min, elapsed / duration);
    //        elapsed += Time.deltaTime;
    //        Debug.Log("Decrease");
    //        yield return null;
    //    }
    //    StartCoroutine(ChangeRadius(min, max, 5f));
    //    //radius = v_end;
    //}
}

