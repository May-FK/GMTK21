using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int goalSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckPlayer();
        }
    }

    void CheckPlayer()
    {
        if (!Player.inGoal) return;
        else if (Player.outOfGoal)
        {
            Debug.Log("Part of you is sticking out!");
        }
        else if (Player.playerSize < goalSize)
        {
            Debug.Log("You are too small!");
        }
        else
        {
            Debug.Log("You fit!");
        }
    }
}
