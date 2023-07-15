using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontrol : MonoBehaviour
{
    // public AudioSource collisionsound;
    public Rigidbody rib;

    public AudioClip clip;
   
   public AudioSource coin;

   public AudioSource life;
    public float stabilizingSpeed;


    private bool right;
    private bool left;
    public float minrot;
    public float maxrot;
    private bool uppoint;
public GameObject coins;

public GameObject powerup;
  
    public Transform localTrans;
  
    void Start()
    {
      
    uppoint=true;
       
    }

   
    void FixedUpdate()


    
    {
        if (right==true)
{
    rib.AddForce(new Vector3((float)-0.01, (float)0.15, 0), (ForceMode)ForceMode.Impulse);
    
    Vector3 velocity = new Vector3(0, 0, 1.5f);
rib.angularVelocity = velocity;

 

}

if (left==true)
{
    rib.AddForce(new Vector3((float)0.01, (float)-0.15, 0), (ForceMode)ForceMode.Impulse);
      Vector3 velocity = new Vector3(0, 0, -1.5f);
rib.angularVelocity = velocity;


}



if(uppoint==true)
{



    
rib.transform.rotation=Quaternion.RotateTowards(rib.transform.rotation,Quaternion.Euler(0,0,0),stabilizingSpeed*Time.deltaTime);

    Vector3 velocity = new Vector3(0, 0, 0);
rib.angularVelocity = velocity;
}



    }



   

public void pointerright()
{


right=true;

uppoint=false;



}


public void pointerleft()
{

left=true;
uppoint=false;



}



public void up()
{
uppoint=true;
right=left=false;




}

 void Update()
    {
        Vector3 playerEulerAngles = localTrans.rotation.eulerAngles;
playerEulerAngles.z=(playerEulerAngles.z>180)? playerEulerAngles.z-360:playerEulerAngles.z;
playerEulerAngles.z=Mathf.Clamp(playerEulerAngles.z,minrot,maxrot);

localTrans.rotation=Quaternion.Euler(playerEulerAngles);


    }
    
    
 
 void OnCollisionEnter(Collision collision){
    if(collision.gameObject.name == "Ground"){
          
    //   collisionsound .Play();

   
       
       
        Destroy(this.gameObject);
    }


 
 }


 void OnTriggerEnter(Collider obj)
 {


if(obj.GetComponent<coinanimation>())
{



coin.PlayOneShot(coin.clip);
 





}


if(obj.GetComponent<powerupdestroyer>())
{


life.Play();


}


 }

 


 }


 









