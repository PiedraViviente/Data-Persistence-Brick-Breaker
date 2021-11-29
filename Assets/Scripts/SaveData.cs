using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveData
{
    public static void SaveGameData()
    {
        //string that contains file path
        string path = Application.persistentDataPath + "/savedata.json";

        //create our save data
        Data d = new Data();

        //d.highScore = GameManager.Manager.HighScore;
    }
}



public class Data
{
        public int highScore;
}
