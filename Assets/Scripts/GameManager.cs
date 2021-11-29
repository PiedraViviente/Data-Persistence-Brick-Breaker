using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] public string playerName;
    public GameObject inputField;

    
    
    
    private void Awake()
{
    
        //This singleton code will let the name be changed between scenes, but does not store the name and highscore
        
       if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else if (Instance != this)
        {
            Destroy(Instance.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        

    }
    

    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;

    }

 
}
