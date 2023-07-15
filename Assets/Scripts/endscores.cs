using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscores : MonoBehaviour
{
    public Text end;
    public Text coinscollected;

    public Text total;
    // Start is called before the first frame update
   void Start()
   {



end.text=playerHealth.final.ToString("0");
coinscollected.text=playerHealth.endcoin.ToString();

total.text=(playerHealth.final+playerHealth.endcoin).ToString("0");


   }

    // Update is called once per frame
   
}
