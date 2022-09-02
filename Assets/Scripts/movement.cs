using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 Jumpforce;
    private bool left;
    private bool right;
    [SerializeField] private AudioSource jumpsound;
    [SerializeField] private GameObject resume;
    void start(){
        left=false;
        right=false;
    }
    void Update()
    {
        if(left)
        {
            Vector2 pos = transform.position;
            pos.x += -1 * Time.deltaTime * speed;
            transform.position = pos;
        }
         if(right)
        {
            Vector2 pos = transform.position;
            pos.x += 1 * Time.deltaTime * speed;
            transform.position = pos;
        }
        if (Input.GetButtonDown("Fire3"))
        {
            if((left == right) && resume.activeInHierarchy)
            {
            GetComponent<Rigidbody2D>().AddForce(Jumpforce);
            jumpsound.Play();
            }
        }

    }
    public void leftdown()
    {
        left=true;
    }

    public void leftup()
    {
        left=false;
    }
    public void rightdown()
    {
        right=true;
    }

    public void rightup()
    {
        right=false;
    }
}
