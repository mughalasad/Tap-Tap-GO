using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Feedback : MonoBehaviour
{
    [SerializeField] private GameObject feedbackmenu;
    [SerializeField] private TMP_InputField email;
    [SerializeField] private TextMeshProUGUI emailtext;
    [SerializeField] private TMP_InputField feedback;
    [SerializeField] private TextMeshProUGUI feedbacktext;
    // Start is called before the first frame update
    void Start()
    {
        feedbackmenu.SetActive(false);
    }
    public void click()
    {
        feedbackmenu.SetActive(true);
    }
    public void close()
    {
        emailtext.text = "";
        feedbacktext.text = "";
        email.text = "";
        feedback.text = "";
        feedbackmenu.SetActive(false);
    }
    public void send()
    {
        string e = email.text;
        string f = feedback.text;
        string url = "https://docs.google.com/forms/u/2/d/e/1FAIpQLSfseYEiCT-07WZJxuMLNvMFU0FR1M0UDiFBcTjyY8e9bsYUwA/formResponse";
        if (e.Length < 1)
        {
            emailtext.text = "Please enter your Email";
            return;
        }
        if (e.Length > 30)
        {
            emailtext.text = "Invalid email";
            return;
        }
        if (e.IndexOf('@')<1 || e.IndexOf('.') < 1)
        {
            emailtext.text = "Invalid email";
            return;
        }
        emailtext.text = "";
        if (f.Length < 1)
        {
            feedbacktext.text = "Please enter some feedback";
            return;
        }
        if (f.Length > 250)
        {
            feedbacktext.text = "Exceeded character limit";
            return;
        }
        feedbacktext.text = "";
        email.text = "";
        feedback.text = "";
        WWWForm form = new WWWForm();
        form.AddField("entry.973027100",e);
        form.AddField("entry.141301989",f);
        UnityWebRequest www = UnityWebRequest.Post(url, form);

        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(UnityWebRequest www)
    {
        yield return www.SendWebRequest();

         // check for errors
         if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.result);// contains all the data sent from the server
            feedbackmenu.SetActive(false);
        }
        else
        {
            Debug.Log("WWW Error: " + www.result);
        }
        yield break; 
    }
}
