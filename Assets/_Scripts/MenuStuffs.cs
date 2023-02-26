using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuStuffs : MonoBehaviour
{

    public AudioSource AudioSource;

    public bool optionsOpen = false;

    public GameObject optionsCanvas;

    public GameObject mainCanvas;

    public Slider audioSlider;


    public static bool EasyMode = false;

    public static bool HardMode = false;

    public GameObject EasyObject;

    public GameObject HardObject;


    public static bool GameActive = false;


    public GameObject inGameCanvas;

    public TimerStuff TimerStuff;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AudioSource.volume = audioSlider.value;

        if (GameActive)
        {
            if (Input.GetKeyDown("o"))
            {
                inGameCanvas.SetActive(true);


            }
           
           if (Input.GetKeyUp("o"))
           {
                inGameCanvas.SetActive(false);


           }


        }

        
    }

    public void OpenOptions()
    {

           optionsCanvas.SetActive(true);
           mainCanvas.SetActive(false);
        


    }

    public void CloseOptions()
    {
            optionsCanvas.SetActive(false);
            mainCanvas.SetActive(true);

    }

    public void PlayGame()
    {
        TimerStuff.Timer = 0;
        GameActive = true;
        SceneManager.LoadScene(1);



    }

    public void QuitGame()
    {

        GameActive = false;
         Application.Quit();
         


    }


    public void Return2Main()
    {
            GameActive = false;
            SceneManager.LoadScene(0);


    }


    public void ToggleEasyMode()
    {
        if (EasyMode)
        {
          EasyMode = false;
          EasyObject.SetActive(false);  


        }
        else
        {

             EasyMode = true;
             EasyObject.SetActive(true);


        }
  

    }

    public void ToggleHardMode()
    {
        if (HardMode)
        {
          HardMode = false;
          HardObject.SetActive(false);  


        }
        else
        {

             HardMode = true;
             HardObject.SetActive(true);


        }
  

        
    }




}
