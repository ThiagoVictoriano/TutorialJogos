using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static bool playerHit = false;

    public static bool gameOver
    {
        get
        {
            return collectableCount <= 0 || playerHit;
        }
    }

    public static void Init()
    {
        collectableCount = 10;
        playerHit = false;
        GameTimer.ResetTimer();
    }

    public static void Collect()
    {
        collectableCount--;
    }

    public static void PlayerGotHit()
    {
        playerHit = true;
    }
}
