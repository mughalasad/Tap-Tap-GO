using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Theme : MonoBehaviour
{
    [SerializeField] private GameObject thememenu;
    [SerializeField] private GameObject Themetab;
    [SerializeField] private GameObject Player;
    [SerializeField] private Toggle themetog;
    [SerializeField] private Toggle playertog;
    //public void enable(bool val)
    //{
    //    if(val)
    //    {
    //        settingmenu.SetActive(true);
    //        shopexit.SetActive(false);
    //    }
    //    else
    //    {
    //        settingmenu.SetActive(false);
    //        shopexit.SetActive(false);
    //    }
    //}
    private void Start()
    {
        thememenu.SetActive(false);
        Themetab.SetActive(true);
        Player.SetActive(false);
        themetog.isOn = true;
        playertog.isOn = false;
    }
    public void click()
    {
        thememenu.SetActive(true);
    }
    public void theme()
    {
        Themetab.SetActive(true);
        Player.SetActive(false);
        themetog.isOn = true;
        playertog.isOn = false;
    }

    public void player()
    {
        Themetab.SetActive(false);
        Player.SetActive(true);
        themetog.isOn = false;
        playertog.isOn = true;
    }
    public void close()
    {
        Themetab.SetActive(true);
        Player.SetActive(false);
        themetog.isOn = true;
        playertog.isOn = false;
        thememenu.SetActive(false);
    }
}
