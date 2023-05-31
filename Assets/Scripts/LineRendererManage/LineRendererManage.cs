using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererManage : MonoBehaviour
{
    LineRenderer line;
    public Transform startPoint;
    public Transform EndPoint;
    Transform target;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        startPoint = GetComponentInChildren<Transform>().Find("Dot1");
        EndPoint = GetComponentInChildren<Transform>().Find("Dot2");
    }

    public IEnumerator LineTrigger()
    {
        yield return new WaitForSeconds(0.2f);
        line.widthCurve.AddKey(0.5f, 0.5f);
        line.SetPosition(0, startPoint.position);
        line.SetPosition(1, EndPoint.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LineTrigger());
        }
    }

    public void LookAtUpperRing()
    {
        Vector3 startPos = startPoint.position;
        target = RingSpawner.inst.SpwanList[0].transform;

        Vector3 dir = (target.transform.position - startPos).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        startPoint.transform.eulerAngles = Vector3.forward * angle;
    }
    public void LookAtLowerRing()
    {
        Vector3 EndPos = EndPoint.position;
        target.position = GameController.inst.player.transform.position;

        Vector3 dir = (target.transform.position - EndPos).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        EndPoint.transform.eulerAngles = Vector3.forward * angle;
    }
}
