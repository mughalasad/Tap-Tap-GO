using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class update : MonoBehaviour, IDataPersistence
{
    private int bundle;
    [SerializeField] private GameObject updatemenu;
    [SerializeField] private GameObject close;
    [SerializeField] private TextMeshProUGUI message;
    static bool check;
    // Start is called before the first frame update
    void Start()
    {
        string url = "https://kinnadu.com/games/taptapgo/config.json";
        //WWW www = new WWW(url);
        UnityWebRequest www = UnityWebRequest.Get(url);
        StartCoroutine(WaitForRequest(www));
    }
    public void LoadData(GameData data) 
    {
        bundle = data.bundlecode;
    }
    public void SaveData(ref GameData data) { }
    IEnumerator WaitForRequest(UnityWebRequest www)
    {
        yield return www.SendWebRequest();

        // check for errors
        if (www.error == null)
        {
            //Debug.Log("WWW Result!: " + www.text);// contains all the data sent from the server
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
        forjson upd = JsonUtility.FromJson<forjson>(www.downloadHandler.text);
        if (upd.Bundlecode>bundle && check)
        {
            check = false;
            updatemenu.SetActive(true);
            if (upd.Forceupdate==true)
            {
                close.SetActive(false);
            }
            message.text = "" + upd.Notice;
        }
    }

    public void closing()
    {
        updatemenu.SetActive(false);
    }

    public void Updating()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.arhpez.taptapgo");
        updatemenu.SetActive(false);
    }
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        check = true;
    }
}
public class forjson
{
    public bool Forceupdate;
    public string Notice;
    public int Bundlecode;
}
