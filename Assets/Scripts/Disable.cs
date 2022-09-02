using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disable : MonoBehaviour
{
    [SerializeField] private Toggle tog;
    [SerializeField] private GameObject settingmenu;
    // Start is called before the first frame update
    void Start()
    {
        if(tog.isOn==false)
        settingmenu.SetActive(false);
    }
}
