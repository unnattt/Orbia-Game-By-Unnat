using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        Invoke("CloseGameObject", 1f);
    }
    void CloseGameObject()
    {
        Destroy(gameObject);
    }

}
