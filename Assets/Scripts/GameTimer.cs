using UnityEngine;

public static class GameTimer
{
    public static float elapsedTime = 0f;

    public static void ResetTimer()
    {
        elapsedTime = 0f;
    }

    public static void UpdateTimer()
    {
        elapsedTime += Time.deltaTime;
    }
}
