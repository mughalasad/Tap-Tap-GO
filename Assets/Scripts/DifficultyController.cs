using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour,IDataPersistence
{

    [SerializeField] private GameObject Medium;
    [SerializeField] private GameObject Hard;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    public void LoadData(GameData data)
    {
        if(data.difficulty==0)
        {
            Medium.SetActive(true);
            Hard.SetActive(false);
        }
        else
        {
            Hard.SetActive(true);
            Medium.SetActive(false);
        }
        if(data.player==0)
        {
            player1.SetActive(true);
            player2.SetActive(false);
        }
        else
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }

    public void SaveData(ref GameData data){}
}
