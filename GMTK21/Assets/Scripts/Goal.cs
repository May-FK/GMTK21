using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int goalSize;
    public int maxMoves;
    // Start is called before the first frame update
    void Start()
    {
        MoveCounter.SetMoves(maxMoves);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckPlayer();
        }

        if(MoveCounter.GetMoves() == maxMoves)
        {
            //CheckPlayer();
        }
    }

    void CheckPlayer()
    {
        //Debug.Log("Checking Player");
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
            LevelChanger.NextScene();
            Debug.Log("You fit!");
        }
    }
}
