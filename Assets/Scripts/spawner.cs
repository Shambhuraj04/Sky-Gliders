using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;
   


    private BoxCollider col;

    
    private float temp;
    float y1, y2;
   
    public float i=3;
    private float velocity;

    private float pos;
    public float speed =20000;









    
   
    void Start()
    {
        col = GetComponent<BoxCollider>();
        y1 = transform.position.y - col.bounds.size.y / 2f;
        y2 = transform.position.y + col.bounds.size.y / 2f;
        StartCoroutine(SpawnCrow(1f));
       
      
       
    }
      
    void LateUpdate()
    {


 i=Mathf.SmoothDamp(i,0.9f,ref velocity,speed*Time.deltaTime);

        
    }
 



    IEnumerator SpawnCrow(float time)
    {
        
     
     
 





      
        
        yield return new WaitForSeconds(i);

        Vector3 temp = transform.position;
        
        temp.y = Random.Range(y1, y2);
        

        Instantiate(enemies[Random.Range(0, enemies.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnCrow(Random.Range(1f, 2f)));
        



    
}

}