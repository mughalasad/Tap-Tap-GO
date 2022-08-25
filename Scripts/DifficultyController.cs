using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour,IDataPersistence
{

    [SerializeField] private GameObject Medium;
    [SerializeField] private GameObject Hard;
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
    }

    public void SaveData(ref GameData data){}
}
