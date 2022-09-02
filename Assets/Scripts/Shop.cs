using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject shopexit;
    [SerializeField] private GameObject shopmenu;
    [SerializeField] private GameObject setting;
    [SerializeField] private GameObject players;
    [SerializeField] private GameObject themes;

    public void click()
    {
        setting.SetActive(false);
        shopexit.SetActive(true);
        shopmenu.SetActive(true);
    }
    public void exit()
    {
        setting.SetActive(true);
        shopexit.SetActive(false);
        shopmenu.SetActive(false); 
        players.SetActive(true);
        themes.SetActive(false);
    }
    void Start()
    {
        if(shopexit.activeInHierarchy)
        shopmenu.SetActive(true);
        else
        shopmenu.SetActive(false);
        players.SetActive(true);
        themes.SetActive(false);
        shopexit.SetActive(false);
    }
    public void player()
    {
        players.SetActive(true);
        themes.SetActive(false);
    }
    public void theme()
    {
        players.SetActive(false);
        themes.SetActive(true);
    }
}
