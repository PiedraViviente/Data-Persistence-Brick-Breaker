using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


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

        LoadHighScore();
    }


    public void CheckHighScore(int points)
    {
        if (points > highScore)
        {
            highScore = points;
            highScoreName = GameManager.Instance.playerName;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int j_highScore;
        public string j_playerName;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.j_highScore = highScore;
        data.j_playerName = highScoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        Debug.Log(Application.persistentDataPath);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.j_highScore;
            highScoreName = data.j_playerName;
        }
    }

}
