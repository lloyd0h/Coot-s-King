using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrasEnable : MonoBehaviour
{
    public GameObject Greenbar;
    public GameObject SaveStates;

    public MenuStuffs MenuStuffs;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuStuffs.EasyMode)
        {
            SaveStates.SetActive(true);



        }
        else
        {


            SaveStates.SetActive(false);

        }

        if (MenuStuffs.HardMode)
        {

            Greenbar.SetActive(false);
                        



        }
        else
        {
              Greenbar.SetActive(true);

        }

    }






}
