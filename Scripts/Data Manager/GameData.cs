using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public bool Gamemute;
    public int score;
    public int difficulty;
    public GameData() 
    {
        this.score=0;
        this.Gamemute=false;
        this.difficulty=0;
    }
}