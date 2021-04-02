using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int Score;
    //public int Lives;
    public string Name;
    public float Delay;

    

    public PlayerData(Player player)
    {
        Score = player.score;
        //Lives = player.lives;
        Name = player.name;
        Delay = player.delay;

        
    }
}
