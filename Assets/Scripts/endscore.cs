using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscore : MonoBehaviour
{
    public Text endtext;
    // Start is called before the first frame update
    void Start()
    {
        endtext.text=     playerHealth.final.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
