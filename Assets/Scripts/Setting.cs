using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField] private GameObject settingmenu;
    [SerializeField] private GameObject instructionmenu;
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
        settingmenu.SetActive(false);
        instructionmenu.SetActive(false);
    }
    public void click()
    {
        settingmenu.SetActive(true);
    }

    public void close()
    {
        settingmenu.SetActive(false);
    }
    public void insclick()
    {
        instructionmenu.SetActive(true);
    }
    public void insclose()
    {
        instructionmenu.SetActive(false);
    }
}
