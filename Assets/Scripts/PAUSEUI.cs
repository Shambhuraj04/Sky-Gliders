using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PAUSEUI : MonoBehaviour
{public GameObject pausemenuui;
public bool clicked=false;



   public static bool gameispaused=false;

    void FixedUpdate()
    {


if(clicked)

{


pause();


        
    }
    }




     void resume()
    {

pausemenuui.SetActive(false);
Time.timeScale=1f;
gameispaused=false;

    }



void pause()
    {


pausemenuui.SetActive(true);
Time.timeScale=0;
gameispaused=true;
    }




public void settrue()
{

clicked=true;


}




public void loadmenu()
{
Time.timeScale=1;
SceneManager.LoadScene(0);


}

public void quit()
{

Application.Quit();


}

public void setfalse()
{

clicked=false;
resume();


}







}
