
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    int y = 12;
    
    

    public  Text scoreText;
    // Start is called before the first frame update

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.x + y).ToString("0");
       
        
    }
}
