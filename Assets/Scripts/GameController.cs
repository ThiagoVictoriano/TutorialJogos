using UnityEngine;

public static class GameController
{
    private static int collactableCount;
    private static bool playerHit = false;

    public static bool gameOver
    {
        get
        {
            return collactableCount <= 0 || playerHit;
        }
    }

    public static void Init()
    {
        collactableCount = 4;
        playerHit = false;
    }

    public static void Collect()
    {
        collactableCount--;
    }

    public static void PlayerGotHit()
    {
        playerHit = true;
    }
}
