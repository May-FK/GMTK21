using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Collider2D left, right, top, bottom;
    SpriteRenderer sr;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag("Player"))
        {
            sr.sprite = sprite;
            sr.sortingOrder = 5;
            left.enabled = false;
            right.enabled = false;
            top.enabled = false;
            bottom.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Destroy"))
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
