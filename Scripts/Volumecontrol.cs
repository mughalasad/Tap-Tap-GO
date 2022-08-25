using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volumecontrol : MonoBehaviour,IDataPersistence
{
    private bool Mute;
    public Toggle tog;
    public AudioMixer mixer;
    public void audioset()
    {
        tog.isOn=Mute;
        if(tog.isOn)
     {  
        mixer.SetFloat("Master",Mathf.Log10(0.001f)*20);
    }
        else
        {mixer.SetFloat("Master",Mathf.Log10(1f)*20);
    }
    }

    public void LoadData(GameData data)
    {
        Mute = data.Gamemute;
        audioset();
    }

    public void SaveData(ref GameData data)
    {
        data.Gamemute=Mute;
    }
    
    public void togglemute(bool mute)
    {
        if(mute)
     {  
        Mute=mute;
        mixer.SetFloat("Master",Mathf.Log10(0.00001f)*20);
     }
        else
        {
            mixer.SetFloat("Master",Mathf.Log10(1f)*20);
            Mute=mute;
        }
        
    }

    // public void mute()
    // {
    //     mixer.SetFloat("MusicVol",0);
    // }

    // Start is called before the first frame update
    


}
