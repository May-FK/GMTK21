using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    bool destroy;
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
        }
        if(Input.GetKeyDown(KeyCode.Space) && destroy)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Destroy"))
        {
            destroy = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Destroy"))
        {
            destroy = false;
        }
    }
}
