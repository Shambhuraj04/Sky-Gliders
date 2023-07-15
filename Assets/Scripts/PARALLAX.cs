using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PARALLAX : MonoBehaviour
{
    private float length,startpos;
    public GameObject cam;
    public float parallaxeffect;
    // Start is called before the first frame update
    void Start()
    {
        startpos= transform.position.x;
        length= GetComponent<MeshRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp=(cam.transform.position.x*(1-parallaxeffect));
        float dist=(cam.transform.position.x * parallaxeffect);

        transform.position = new Vector3(startpos + dist, transform.position.y);

        if (temp>startpos+length) startpos+=length;
        else if(temp<startpos-length) startpos-=length;
    }
}