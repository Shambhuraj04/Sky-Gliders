using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
   public Transform player;
 void FixedUpdate () 
 {
    
        this.transform.position = new Vector3(player.position.x+7.9f,4.2559f, -15.5f);
 } 
}
 
