using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    [SerializeField] private GameObject settingmenu;
    public void enable(bool val)
    {
        if(val)
        {
            settingmenu.SetActive(true);
        }
        else
        {
            settingmenu.SetActive(false);
        }
    }
}
