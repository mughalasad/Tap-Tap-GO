using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dropdow : MonoBehaviour,IDataPersistence
{
    // public TMPro.TMP_Dropdown dropp;
    [SerializeField] private Toggle easy;
    [SerializeField] private Toggle medium;
    [SerializeField] private Toggle hard;
    [SerializeField] private Toggle player1;
    [SerializeField] private Toggle player2;
    [SerializeField] private Toggle player3;
    [SerializeField] private Toggle theme1;
    [SerializeField] private Toggle theme2;
    private int number;
    private int player;
    private int themenumber;
    int click = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            click++;
            StartCoroutine(ClickTime());

            if (click > 1)
            {
                Application.Quit();
            }
        }
    }
    IEnumerator ClickTime()
    {
        yield return new WaitForSeconds(0.5f);
        click = 0;
    }
    public void LoadData(GameData data)
    {
        // dropp.value =data.player;
        if(data.difficulty==0)
        {
            selecteasy();
        }
        else if(data.difficulty==1)
        {
            selectmedium();
        }
        else
        {
            selecthard();
        }
        if(data.player==0)
        {
            selectplayer1();
        }
        else if (data.player==1)
        {
            selectplayer2();
        }
        else
        {
            selectplayer3();
        }
        if (data.theme == 0)
        {
            selecttheme1();
        }
        else
            selecttheme2();
    }

    public void SaveData(ref GameData data)
    {
        data.difficulty = number;
        data.player = player;
        data.theme = themenumber;
    }
    public void selecteasy()
    {
        easy.isOn=true;
        medium.isOn = false;
        hard.isOn=false;
        number=0;
    }
    public void selectmedium()
    {
        easy.isOn = false;
        medium.isOn = true;
        hard.isOn = false;
        number = 1;
    }

    public void selecthard()
    {
        easy.isOn = false;
        medium.isOn = false;
        hard.isOn = true;
        number =2;
    }
    public void selectplayer1()
    {
        player1.isOn=true;
        player2.isOn=false;
        player3.isOn = false;
        player =0;
    }
    public void selectplayer2()
    {
        player1.isOn=false;
        player2.isOn=true;
        player3.isOn = false;
        player =1;
    }
    public void selectplayer3()
    {
        player1.isOn = false;
        player2.isOn = false;
        player3.isOn = true;
        player = 2;
    }
    public void selecttheme1()
    {
        theme1.isOn = true;
        theme2.isOn = false;
        themenumber = 0;
    }
    public void selecttheme2()
    {
        theme1.isOn = false;
        theme2.isOn = true;
        themenumber = 1;
    }
}
