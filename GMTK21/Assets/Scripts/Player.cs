using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 position;
    Collider2D col;
    public static int playerSize;
    public static bool outOfGoal;
    public static bool inGoal;
    // Start is called before the first frame update
    void Start()
    {
        playerSize = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        playerSize = transform.childCount;
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
        if (collision.gameObject.CompareTag("Out Of Goal"))
        {
            outOfGoal = true;
        }
        if (collision.gameObject.CompareTag("In Goal"))
        {
            inGoal = true;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            col = collision;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Out Of Goal"))
        {
            outOfGoal = false;
        }
        if (collision.gameObject.CompareTag("In Goal"))
        {
            inGoal = false;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            col = null;
        }
    }
}
