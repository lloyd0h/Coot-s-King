using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject Camera;

    public Transform camPosition1;

    public Transform camPosition2;

    public Transform camPosition3;

    public Transform camPosition4;

    public Transform camPosition5;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Zone1()
    {
        Camera.transform.position = camPosition1.transform.position;

    }

    public void Zone2()
    {
        Camera.transform.position = camPosition2.transform.position;

    }

    public void Zone3()
    {
        Camera.transform.position = camPosition3.transform.position;

    }        

    public void Zone4()
    {
        Camera.transform.position = camPosition4.transform.position;

    }

    public void Zone5()
    {
        Camera.transform.position = camPosition5.transform.position;

    }

}
