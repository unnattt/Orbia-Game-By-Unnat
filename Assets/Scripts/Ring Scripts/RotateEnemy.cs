using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    public GameObject target;
    public float _enemyAngle = 20f;
    

    private void Update()
    {
        RotateEnemyOnRingOrbit();
    }

    public void RotateEnemyOnRingOrbit()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, _enemyAngle * Time.deltaTime);
    }
}
