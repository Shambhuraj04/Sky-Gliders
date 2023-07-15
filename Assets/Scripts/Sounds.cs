using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{


    public AudioSource enemy;
    public AudioSource coins;
    public AudioSource dead;
    public AudioSource ground;
    public AudioSource upperbound;
    public AudioSource powerup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "enemy")
        {
            enemy.Play();
        }
        else if (collision.gameObject.name == "coins")
        {


            coins.Play();



        }
        else if (collision.gameObject.name == "ground")
        {


            ground.Play();



        }


        else if (collision.gameObject.name == "upperbound")
        {


            upperbound.Play();



        }
        else if (collision.gameObject.name == "powerup")
        {


            powerup.Play();



        }






    }


    public void ButtonSound()
    {
        upperbound.Play();



    }
}




