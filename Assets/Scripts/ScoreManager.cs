using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int highScore;
    public string highScoreName;

    private void Awake()
    {


        // This singleton code will not let the name be changed between scenes, but does store the name and high score
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
        Instance = this;
    }
    public void CheckHighScore(int points)
    {
        if (points > highScore)
        {
            highScore = points;
            highScoreName = GameManager.Instance.playerName;
        }
    }
}
