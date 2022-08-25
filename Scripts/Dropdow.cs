using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdow : MonoBehaviour,IDataPersistence
{
    public TMPro.TMP_Dropdown dropp;
    private int number;
    // Start is called before the first frame update
    public void dropdown (int val)
    {
        if(val==0)
        {
            number=0;
        }
        else
        {
            number=1;
        }
    }

     public void LoadData(GameData data)
    {
        dropp.value =data.difficulty;
    }

    public void SaveData(ref GameData data)
    {
        data.difficulty=number;
    }
}
