using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupdestroyer : MonoBehaviour
{


    


void Start()
{

StartCoroutine("idk");



}
void Update()
{





}


    IEnumerator idk()
    {

yield return new WaitForSeconds(15f);
Destroy(this.gameObject);


    }
  







     void OnTriggerEnter(Collider obj){
    if(obj.gameObject.name == "player"){
    
      
Destroy(this.gameObject);

        

      
        }
   
}}












