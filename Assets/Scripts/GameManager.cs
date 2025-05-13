using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int currentTurn = 0;
    public int maxTurns = 10;
    public TMP_Text turnText;
    public TMP_Text scoreText;

    private int playerScore = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateTurnText();
        UpdateScoreText();
    }

    public void EndTurn()
    {
        currentTurn++;
        if (currentTurn > maxTurns)
        {
            EndGame();
        }
        else
        {
            UpdateTurnText();
        }
    }

    void EndGame()
    {
        // Show final score, and end the game.
        Debug.Log("Game Over! Final Score: " + playerScore);
    }

    void UpdateTurnText()
    {
        turnText.text = "Turn: " + currentTurn + "/" + maxTurns;
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + playerScore;
    }

    public void AddScore(int score)
    {
        playerScore += score;
        UpdateScoreText();
    }
}
