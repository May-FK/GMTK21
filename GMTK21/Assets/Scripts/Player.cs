using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 position;
    Collider2D col;
    Rigidbody2D rb;
    public static int playerSize;
    public static bool outOfGoal;
    public static bool inGoal;

    bool left, right, up, down;
    // Start is called before the first frame update
    void Start()
    {
        playerSize = transform.childCount;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerSize = transform.childCount;
        //position = transform.position;
        Move();
        //transform.position = position;
        if (col) Connect();
        if (Input.GetKeyDown(KeyCode.R))
        {
            LevelChanger.ReloadScene();
        }
    }

    void FixedUpdate()
    {
        position = transform.position;
        if (up)
        {
            position.y += 1;
        }
        else if (down)
        {
            position.y -= 1;
        }
        else if (right)
        {
            position.x += 1;
        }
        else if (left)
        {
            position.x -= 1;
        }
        rb.MovePosition(position);
        left = false;
        right = false;
        up = false;
        down = false;
    }

    void Move()
    {
        if (left || right || up || down) return;
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
            //position.y += 1f;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
            //position.x -= 1f;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
            //position.y -= 1f;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
            //position.x += 1f;
        }

        else return;

        MoveCounter.DecrementMoves();
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
