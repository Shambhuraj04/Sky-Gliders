using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {  public float speed = 5.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;
    // public AudioSource collisionsound;
   

    // Use this for initialization
    void Start () {
          rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
// collisionsound=GetComponent<AudioSource>();
    }
     void OnCollisionEnter(Collision collision){
    if(collision.gameObject.name == "player"){
      
        Destroy(this.gameObject);
         

    }
 else if(collision.gameObject.name == "destroyer"){
        Destroy(this.gameObject);
    }

    
 }

    // Update is called once per frame
    void Update () {
        
     }
    }
