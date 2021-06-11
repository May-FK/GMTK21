using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 position;
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        Move();
        transform.position = position;
        if (col) Connect();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            position.y += 1f;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            position.x -= 1f;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            position.y -= 1f;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            position.x += 1f;
        }

        else return;

        MoveCounter.AddToMoves();
    }

    void Connect()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (col.gameObject.transform.parent == null)
            {
                col.transform.SetParent(this.transform);
                col.gameObject.tag = "Player";
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) return;
        col = collision;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        col = null;
    }
}
