using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int score; 
    public string name;
    public float delay;
    //public int lives;


    public void Update()
    {
        score = WordManager.score;
        //lives = Livesdropdown.lives;
        name = SendText.theName;
    }

    public void Start()
    {
        delay = WordTimer.wordDelay;
    }

    public void SavePlayer()
    {
        Save.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        SceneManager.LoadScene("Main");
        PlayerData data = Save.LoadPlayer();
        WordManager.score = data.Score;
        //Livesdropdown.lives = data.Lives;
        SendText.theName = data.Name;
        WordTimer.wordDelay = data.Delay;
        Time.timeScale = 1f;
        
    }

    public void SaveAsJson()
    {
        Save.SaveAsJSON(this);
    }
}
