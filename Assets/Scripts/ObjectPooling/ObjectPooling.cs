using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling inst;
    public List<GameObject> pooledObjects;
    public List<GameObject> SpwanList;
    public GameObject[] objectToPool;
    public GameObject spwanPoint;
    public int amountToPool;

    void Awake()
    {
        inst = this;
    }

    void Start()
    { 
        ObjectPoolingRing();
        SpwanerRing();
    }

    void ObjectPoolingRing()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool[i]);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    public void SpwanerRing()
    {
        for (int i = 0; i < 1; i++)
        {
            GameObject ringPrefab = GetPooledObject();
            if (ringPrefab != null)
            {
                ringPrefab.transform.position = RandomSpwanPoint();
                ringPrefab.SetActive(true);
                SpwanList.Add(ringPrefab);
            }
        }
      
    }

    public Vector2 RandomSpwanPoint()
    {
        float xvalue = Random.Range(-2f, 2f);
        float yvalue = Random.Range(4f, 4f);
        spwanPoint.transform.position = new Vector2(spwanPoint.transform.position.x + xvalue, spwanPoint.transform.position.y + yvalue);
        return spwanPoint.transform.position;
    }
}
