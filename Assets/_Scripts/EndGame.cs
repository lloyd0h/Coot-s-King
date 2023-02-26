using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{

    public TimerStuff TimerStuff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9)
        {
            TimerStuff.timerIsRunning = false;
            GameWon();

            //stop timer here

        }
    }



    void GameWon()
    {

         Invoke("EndScreen", 3.5f);

    }


    void EndScreen()
    {

                SceneManager.LoadScene(2);


    }
}
