using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MoveCounter
{
    private static int moves;

    /*public static void ResetMoves()
    {
        moves = 0;
    }*/

    public static void SetMoves(int maxMoves)
    {
        moves = maxMoves;
    }

    public static int GetMoves()
    {
        return moves;
    }

    public static void DecrementMoves()
    {
        moves -= 1;
    }
}
