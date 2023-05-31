using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public List<GameObject> RingsObjects;
    public List<GameObject> SpwanList;
    public GameObject spwanPoint;
    public int ringCount;

    public static RingSpawner inst;

    private void Awake()
    {
        inst = this;
    }

    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            SpwanerRing();
        }
    }

    public void SpwanerRing()
    {
        GameObject random = Instantiate(RingsObjects[Random.Range(0, RingsObjects.Count)]);
        random.transform.position = RandomSpwanPoint();
        SpwanList.Add(random);
    }

    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(-1.8f, 1.8f);
        float yvalue = Random.Range(4.2f, 4.2f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;
    }
}
