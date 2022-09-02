using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    [SerializeField] private GameObject settingmenu;
    [SerializeField] private GameObject shopexit;
    public void enable(bool val)
    {
        if(val)
        {
            settingmenu.SetActive(true);
            shopexit.SetActive(false);
        }
        else
        {
            settingmenu.SetActive(false);
            shopexit.SetActive(false);
        }
    }
}
