using System.Collections;
using UnityEngine;
using TMPro;

public class Hard : MonoBehaviour,IDataPersistence
{
[SerializeField]
    private GameObject[] obs;
    private GameObject spawn;
    private int randomindex;
    private int randomside;
    private int spd=0;
    private int themes;
    [SerializeField] public TextMeshProUGUI scoretext;

    [SerializeField] private Transform UpPos,downPos;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;
    private GameObject player;
    scorecounter score = new scorecounter();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnobs());
    }

    IEnumerator spawnobs()
    {
        while(true)
        {
        yield return new WaitForSeconds(1.4f);
        if(player1.activeInHierarchy)
                player=player1;
        else if (player2.activeInHierarchy)
                player = player2;
        else if (player3.activeInHierarchy)
                player = player3;
            if (themes == 0)
                randomindex = Random.Range(0, 6);
        else
                randomindex = Random.Range(6, obs.Length);
            randomside = Random.Range(0,2);
        spawn = Instantiate(obs[randomindex]);
        spd = Random.Range(4,6);
        // Debug.Log(spd);
        if(randomside==0)
        {
            spawn.transform.position=UpPos.position;
            spawn.GetComponent<Monster>().speed = -6;
            spawn.GetComponent<Monster>().score = score;
            spawn.GetComponent<Monster>().player=player;
            spawn.transform.localScale= new Vector3(spawn.transform.localScale.x,-spawn.transform.localScale.y,spawn.transform.localScale.z);

        }
        else
        {
            spawn.transform.position=downPos.position;
            spawn.GetComponent<Monster>().speed = -6;
            spawn.GetComponent<Monster>().score = score;
            spawn.GetComponent<Monster>().player=player;
        }
        }
    }


    // Update is called once per frame
    void Update()
    {
        scoretext.text = ""+ score.val();
    }
    public void LoadData(GameData data)
    {
        themes = data.theme;
    }

    public void SaveData(ref GameData data)
    {
        if(score.val()>data.score)
        {
            data.score=score.val();
        }
    }
}
