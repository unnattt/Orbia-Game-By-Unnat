using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (RingSpawner.inst.SpwanList.Count == 2)
        {
            RingSpawner.inst.SpwanerRing();
        }
        RingSpawner.inst.SpwanList.Remove(collision.gameObject);

    }
}
