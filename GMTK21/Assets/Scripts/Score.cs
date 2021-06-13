using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text moves;
    // Update is called once per frame
    void Update()
    {
        if(moves != null)
            moves.text = "Moves Remaining: " + MoveCounter.GetMoves();
    }
}
