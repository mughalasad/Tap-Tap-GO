using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour,IDataPersistence
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI scoretext;
    private int Score;
    
    public void LoadData(GameData data)
    {
        Score = data.score;
        highscore();
        //Debug.Log(Application.version);
    }

    public void SaveData(ref GameData data)
    {
        scoretext.text = ""+ Score;
    }
    
    public void highscore()
    {
        scoretext.text = ""+ Score;
    }
    public void start()
    {
        SceneManager.LoadScene("Game");   
    }
}
