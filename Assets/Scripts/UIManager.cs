using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public TMP_Text tempoFinalText;

    void Update()
    {
        if (!GameController.gameOver)
        {
            GameTimer.UpdateTimer();
        }
        else
        {
            endGamePanel.SetActive(true);
            tempoFinalText.text = "Tempo: " + GameTimer.elapsedTime.ToString("F2") + "s";
        }
    }
}
