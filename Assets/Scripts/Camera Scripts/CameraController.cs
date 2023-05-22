using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public GameObject Camera;
    public float Offsets;
    public float camPosy;
    Vector3 PlayerPos;


    private void Update()
    { 
        PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y + camPosy, transform.position.z);
        Camera.transform.position = Vector3.Lerp(transform.position, PlayerPos, Offsets * Time.deltaTime);
    }

}
