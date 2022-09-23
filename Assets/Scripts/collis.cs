using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class collis : MonoBehaviour
{
    [SerializeField] private GameObject die;
    [SerializeField] private GameObject pausebutton;
    [SerializeField] private AudioSource Backmusic;
    #if UNITY_IOS
      string  gameid="4907604";
    #else
      string  gameid="4907605";
    #endif
    void Start()
    {
        die.SetActive(false);
        Time.timeScale = 1f;
        pausebutton.SetActive(true);
        Backmusic.Play();
        Advertisement.Initialize(gameid);
        
    }
    public void Playad(){
        if(Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }  
    }
    void Update()
    {
     if (transform.position.x < -8.97 || transform.position.x > 8.77 || transform.position.y < -4.8 || transform.position.y > 5.5)
       {  
        Time.timeScale = 0f;
        die.SetActive(true);
        pausebutton.SetActive(false);
        Backmusic.Stop();
        Playad();
        DataPersistenceManager.instance.SaveGame();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        bool col = collision.gameObject.CompareTag("Ground");
        if (col==false)
            {
                Time.timeScale = 0f;
                die.SetActive(true);
                pausebutton.SetActive(false);
                Backmusic.Stop();
                Playad();
                DataPersistenceManager.instance.SaveGame();
            }

    }
}
