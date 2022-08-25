using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Player;
    void Start()
    {
        Player.SetActive(false);
        
    }
}
