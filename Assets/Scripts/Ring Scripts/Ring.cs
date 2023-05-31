using System.Collections;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public float changeValueTo;
    public float changeValueforColor;
    public float startColor;
    public float endColor;
    public float maxScale;
    public float minScale;
    GameObject ring;
    public SpriteRenderer[] RingChild;
    public  CircleCollider2D[] RingChildCollider;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject, 1f);
    }
    private void Start()
    {
        ring = GetComponent<GameObject>();
    }

    void ScaleChild()
    {
        StartCoroutine(ChangeScaleAndColor(minScale, maxScale, 2f));
    }

    void ChildArray()
    {
        ring = transform.GetChild(0).gameObject;
        for (int i = 0; i < ring.transform.childCount; i++)
        {
            RingChild[i] = ring.transform.GetChild(i).GetComponentInChildren<SpriteRenderer>();
            RingChildCollider[i] = ring.transform.GetChild(i).GetComponentInChildren<CircleCollider2D>();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChildArray();
        ScaleChild();
    }

    IEnumerator ChangeScaleAndColor(float startScale, float endScale,float duration)
    {
        ring = transform.GetChild(0).gameObject;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            changeValueTo = Mathf.Lerp(startScale, endScale, elapsed / duration);
            changeValueforColor = Mathf.Lerp(1, 0, elapsed / duration);
            elapsed += Time.deltaTime;
            for (int i = 0; i < ring.transform.childCount; i++)
            {
                ring.transform.localScale = new Vector2(changeValueTo, changeValueTo);
                RingChild[i].color = new Color(1,1,1,changeValueforColor);
                RingChildCollider[i].enabled = false;
            }
            yield return null;
        }
        
    }

}
