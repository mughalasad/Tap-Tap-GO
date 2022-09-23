using UnityEngine;

public class DifficultyController : MonoBehaviour,IDataPersistence
{
    [SerializeField] private GameObject Easy;
    [SerializeField] private GameObject Medium;
    [SerializeField] private GameObject Hard;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;
    [SerializeField] private GameObject theme1;
    [SerializeField] private GameObject theme2;
    public void LoadData(GameData data)
    {
        if(data.difficulty==0)
        {
            Easy.SetActive(true);
            Medium.SetActive(false);
            Hard.SetActive(false);
        }
        else if(data.difficulty==1)
        {
            Easy.SetActive(false);
            Medium.SetActive(true);
            Hard.SetActive(false);
        }
        else
        {
            Easy.SetActive(false);
            Medium.SetActive(false);
            Hard.SetActive(true);
        }
        if(data.player==0)
        {
            player1.SetActive(true);
            player2.SetActive(false);
            player3.SetActive(false);
        }
        else if (data.player==1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
            player3.SetActive(false);
        }
        else
        {
            player1.SetActive(false);
            player2.SetActive(false);
            player3.SetActive(true);
        }
        if (data.theme == 0)
        {
            theme1.SetActive(true);
            theme2.SetActive(false);
        }
        else
        {
            theme1.SetActive(false);
            theme2.SetActive(true);
        }
    }

    public void SaveData(ref GameData data){}
}
