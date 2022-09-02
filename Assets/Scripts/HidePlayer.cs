using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Player2;
    void Start()
    {
        Player.SetActive(false);
        Player2.SetActive(false);
    }
}
