using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<Transform> LevelsStartPos;
    public List<Transform> AllLevelsPos;
    public Transform target;
    public GameObject player;
    bool IsMove = false;
    float _speedPlayer = 5f;
    

    public static GameController inst;

    private void Awake()
    {
        inst = this;
        Time.timeScale = 0f;
    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
              IsMove = true;
              AngleSetTowardsNextRing();
            }
        }

        if (IsMove == true)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, target.position, _speedPlayer * Time.deltaTime);
        }

        if (player.transform.position == target.position)
        {
            IsMove = false;
            player.transform.rotation = target.rotation;
            target = target.GetComponent<Ring>().targetRing; 
        }
    }

    void AngleSetTowardsNextRing()
    {
        Vector3 dir = target.position - player.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        player.transform.eulerAngles = Vector3.forward * angle;
    }
    
}
