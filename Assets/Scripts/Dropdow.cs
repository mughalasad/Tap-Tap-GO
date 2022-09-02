using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdow : MonoBehaviour,IDataPersistence
{
    // public TMPro.TMP_Dropdown dropp;
    [SerializeField] private Toggle easy;
    [SerializeField] private Toggle hard;
    [SerializeField] private Toggle player1;
    [SerializeField] private Toggle player2;
    private int number;
    private int player;
    // Start is called before the first frame update
    // public void dropdown (int val)
    // {
    //     if(val==0)
    //     {
    //         player=0;
    //     }
    //     else
    //     {
    //         player=1;
    //     }
    // }

     public void LoadData(GameData data)
    {
        // dropp.value =data.player;
        if(data.difficulty==0)
        {
            selecteasy();
        }
        else
        {
            selecthard();
        }
        if(data.player==0)
        {
            selectplayer1();
        }
        else
        {
            selectplayer2();
        }
    }

    public void SaveData(ref GameData data)
    {
        data.difficulty=number;
        data.player=player;
    }
    public void selecteasy()
    {
        easy.isOn=true;
        hard.isOn=false;
        number=0;
    }
    public void selecthard()
    {
        hard.isOn=true;
        easy.isOn=false;
        number=1;
    }
    public void selectplayer1()
    {
        player1.isOn=true;
        player2.isOn=false;
        player=0;
    }
    public void selectplayer2()
    {
        player1.isOn=false;
        player2.isOn=true;
        player=1;
    }
}
