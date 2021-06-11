using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MoveCounter
{
    private static int moves;

    public static int GetMoves()
    {
        return moves;
    }

    public static void AddToMoves()
    {
        moves += 1;
    }
}
