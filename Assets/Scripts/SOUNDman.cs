using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SOUNDman : MonoBehaviour
{[SerializeField] Image soundonicon;
[SerializeField] Image soundofficon;

   private bool muted=false;
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
PlayerPrefs.SetInt("muted",0);



        }

        else
        {

load();


        }

        Updatebuttontext();

        AudioListener.pause=muted;
    }
    public void OnButtonPress()
    {

if(muted==false)
{

muted=true;
AudioListener.pause=true;



}
else
{

muted=false;
AudioListener.pause=false;


}

save();
Updatebuttontext();


    }



private void Updatebuttontext()
{


if(muted==false)
{
soundonicon.enabled=true;
soundofficon.enabled=false;


}

else{




    soundonicon.enabled=false;
    soundofficon.enabled=true;
}


}
    



    private void load()
    {


muted=PlayerPrefs.GetInt("muted")==1;


    }


    private void save()
    {


PlayerPrefs.SetInt("muted",muted?1:0);


    }

}
