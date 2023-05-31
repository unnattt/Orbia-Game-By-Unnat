using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public GameObject Camera;
    public float time;
    public float camPosy;
    Vector3 PlayerPos;

    public Action onstart;

    private void OnEnable()
    {
        GameStateManager.onStateChange += ChangeState;
    }

    private void ChangeState(GameStates state)
    {
        switch (state)
        {
            case GameStates.HomeScreen:
                onstart -= CameraStartPoint;
                break;
            case GameStates.MainMenu:
                onstart -= CameraStartPoint;
                break;
            case GameStates.Setting:
                onstart -= CameraStartPoint;
                break;
            case GameStates.GameOver:
                onstart -= CameraStartPoint;
                break;
            case GameStates.GamePlay:
                onstart += CameraStartPoint;
                break;
        }
    }

    void CameraStartPoint()
    {
        PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y + camPosy, transform.position.z);
        Camera.transform.position = Vector3.Lerp(transform.position, PlayerPos, time * Time.deltaTime);

        float diff = Vector2.Distance(Camera.transform.position, Player.transform.position);
        if (diff < 3f)
        {
            time = 4f;
        }
    }

    private void Update()
    {
        onstart?.Invoke();
    }
}
