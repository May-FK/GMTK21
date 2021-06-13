using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int goalSize;
    public int maxMoves;
    public GameObject retryScreen;
    public GameObject thanks;
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

        if(MoveCounter.GetMoves() == 0)
        {
            FinalCheckPlayer();
        }
    }

    void CheckPlayer()
    {
        //Debug.Log("Checking Player");
        if (!Player.inGoal) return;
        else if (Player.outOfGoal)
        {
            //Debug.Log("Part of you is sticking out!");
        }
        else if (Player.playerSize < goalSize)
        {
           // Debug.Log("You are too small!");
        }
        else
        {
            LevelChanger.NextScene();
           // Debug.Log("You fit!");
        }
    }
    void FinalCheckPlayer()
    {
        //Debug.Log("Checking Player");
        if (!Player.inGoal) Debug.Log("rip");
        else if (Player.outOfGoal)
        {
            //Debug.Log("Part of you is sticking out!");
        }
        else if (Player.playerSize < goalSize)
        {
            // Debug.Log("You are too small!");
        }
        else
        {
            if(SceneManager.GetActiveScene().name == "Level 10")
            {
                thanks.SetActive(true);
                Time.timeScale = 0;
            }
            LevelChanger.NextScene();
            // Debug.Log("You fit!");
        }

        retryScreen.SetActive(true);
        Time.timeScale = 0;
    }

}
