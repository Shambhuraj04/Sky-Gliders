using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;
   


    private BoxCollider col;
    float y1, y2;
    public float spawnTime;
    public float SpawnDelay;
    private float i;

    private float pos;
   
    void Start()
    {
        col = GetComponent<BoxCollider>();
        y1 = transform.position.y - col.bounds.size.y / 2f;
        y2 = transform.position.y + col.bounds.size.y / 2f;
        StartCoroutine(SpawnCrow(1f));
       
      
    
  



    IEnumerator SpawnCrow(float time)
    {
        yield return new WaitForSeconds(3);

        Vector3 temp = transform.position;
        
        temp.y = Random.Range(y1, y2);
        

        Instantiate(enemies[Random.Range(0, enemies.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnCrow(Random.Range(1f, 2f)));
        



    
}

}}