using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStateSystem : MonoBehaviour
{
    public bool saveStatesOn = true;

    public GameObject player; //player gameobject from which we derive the players transform and teleport the player

    public Transform playerPos; //player current position (only set when called upon)

    public GameObject saveStateMarker; //visual identifier for save location

    public Transform OldplayerPos; //last checkpoint position, in case player needs to undo last save

    public PlayerController PlayerController;


    //Potential bugs/things that could be improved upon
    //should probably check if the player is grounded and only allow them to set a checkpoint if they are. 
        

    // Start is called before the first frame update
    void Start()
    {
         playerPos.transform.position = player.transform.position;
         OldplayerPos.transform.position = player.transform.position;
    }

    void setPos()
    {
        //invoked with delay as to not bug out setting positions at the same time
        playerPos.transform.position = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (saveStatesOn)
        {
            saveStateMarker.transform.position = playerPos.transform.position;


            if (PlayerController.isGrounded)
            {
                

                if (Input.GetKey("left shift") && Input.GetKey("5"))
                {
                    Debug.Log("SaveState Saving");

                    //save current position to old one

                        OldplayerPos.transform.position = playerPos.transform.position;
                      Invoke("setPos", 0.2f);  

                    //save new position to playerpos

                    


                  

                }

            }


            if (Input.GetKey("left shift") && Input.GetKey("3"))
            {
                Debug.Log("SaveState Loading");

                 player.transform.position = playerPos.transform.position;


            }


            if (Input.GetKey("left shift") && Input.GetKey("7"))
            {

                playerPos.transform.position = OldplayerPos.transform.position;


            }






        }
        
    }



}
