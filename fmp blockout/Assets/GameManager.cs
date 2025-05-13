using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cameraObj;
    public GameObject playerObj;

    public float switchDelay;
    float nextDelay;

    public bool isCam;

    void Update()
    {
        nextDelay += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.F) && nextDelay >= switchDelay)
        {
            nextDelay = switchDelay;
            if(!isCam)
            {
                // set the cam to active
                cameraObj.SetActive(true);
                // set player to false
                playerObj.SetActive(false);

                isCam = true;
            }
            else
            {
                isCam = false;
                // set cam to false
                cameraObj.SetActive(false);
                // set player to active
                playerObj.SetActive(true);
            }
        }
    }
}
