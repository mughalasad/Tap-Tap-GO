using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Monster : MonoBehaviour
{

    public float speed;
    private Rigidbody2D mybody;
    public GameObject player;
    bool view = true;
    public scorecounter score;

    void Awake(){

        mybody = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(speed,mybody.velocity.y);
        if((player.transform.position.x>(mybody.transform.position.x))&& view)
        {
        score.increment();
        GetComponent<AudioSource>().Play();
        view = false;
        }
    }  
}