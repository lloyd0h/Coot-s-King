using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{


    public CameraControl CC;

    public bool isColliding = false;


    public int screenNumber = 0;
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
            Debug.Log("Player collision detected");

            ChangeCamera();

        }


    }

    void ChangeCamera()
    {
        if (screenNumber == 1)
        {

            CC.Zone1();


        }

        if (screenNumber == 2)
        {

            CC.Zone2();


        }

        if (screenNumber == 3)
        {

            CC.Zone3();


        }

        if (screenNumber == 4)
        {

            CC.Zone4();


        }

        if (screenNumber == 5)
        {

            CC.Zone5();


        }
        


    }

}
