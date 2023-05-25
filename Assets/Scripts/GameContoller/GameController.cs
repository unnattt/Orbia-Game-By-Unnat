using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{

    public GameObject player;
    bool IsMove = true;
    public float duration;
    public Action OnMove;
    GameObject target;


    public static GameController inst;

    private void Awake()
    {
        inst = this;
    }

    public void StartMoveMent()
    {
        OnMove += PlayerMove;
    }

    public void StopMoveMent()
    {
        OnMove = null;
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsMove)
        {
            IsMove = false;
            Debug.Log("value: " + IsMove);
            StartCoroutine(PlayerMovefromOnePoint());
        }
        //OnMove.Invoke();
    }

    void PlayerMove()
    {

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if(touch.phase == TouchPhase.Ended)
        //    {
        //      IsMove = true;               
        //    }
        //}

        //if (IsMove == true)
        {
            target = ObjectPooling.inst.SpwanList[0];
            player.transform.position = Vector2.Lerp(player.transform.position, target.transform.position, duration);
            AngleSetTowardsNextRing();
        }

        float diff = Vector2.Distance(player.transform.position, target.transform.position);
        if (diff < 0.2f)
        {
            IsMove = false;
            player.transform.rotation = target.transform.rotation;
        }
    }

    void AngleSetTowardsNextRing()
    {
        Vector3 dir = (target.transform.position - player.transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        player.transform.eulerAngles = Vector3.forward * angle;
    }

    IEnumerator PlayerMovefromOnePoint()
    {

        Debug.Log("value1: " + IsMove);
        Vector3 startPos = player.transform.position;
        target = RingSpawner.inst.SpwanList[0];
        float time = 0f;
        while (time < duration)
        {
            player.transform.position = Vector2.Lerp(startPos, target.transform.position, time / duration);
            Debug.Log(target.transform.position);
            time += Time.deltaTime;
            AngleSetTowardsNextRing();

            yield return null;
        }
        player.transform.position = target.transform.position;

        Debug.Log("value3: " + IsMove);
        IsMove = true;
        player.transform.rotation = target.transform.rotation;
    }

}
