using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  playerHealth : MonoBehaviour
{
    
    
    
    public float health;


    public static float final;
    public static float endcoin;
    public Slider slider;
    public AudioSource upper;
    public AudioSource ground;
    public AudioClip clip;
    
// public Transform 
    void Start()
    {
    }
    void Update()
    {
        slider.value = health;
        if (health <= 0)
        {
            Destroy(this.gameObject);
             final = this.transform.position.x + 12;

             

endcoin=CoinCounter.coinamount;

            ground.Play();
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(3);

        }

        if(health>100)
        {

health=100;


        }




    }
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Enemy")
        { health = health - 25f;
        ground.PlayOneShot(ground.clip);
        
         }

        else if (obj.gameObject.tag == "upperbound")
        {

            health = health - 10f;
            upper.Play();


        }


        else if (obj.gameObject.tag == "Ground")
        {
            health = 0;

           
            


            ground.Play();
        }





    }

    void OnTriggerEnter(Collider obt)
    {
        if (obt.gameObject.tag == "life")
        { health = health +50f;
         }

}
}