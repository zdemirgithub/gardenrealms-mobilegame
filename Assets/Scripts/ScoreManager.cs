using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int totalScore = 0;

    public void AddToScore(int score)
    {
        totalScore += score;
        Debug.Log("Current Score: " + totalScore);
    }

    public void ResetScore()
    {
        totalScore = 0;
    }
}
