using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCounter : MonoBehaviour
{


    Text text;
    public static int coinamount;
    // Start is called before the first frame update
    void Start()
    {
text=GetComponent<Text>();
coinamount=0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text= coinamount.ToString();



        



    }
}
