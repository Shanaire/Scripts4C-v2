using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartToggle : MonoBehaviour
{
    /* 
     * This Script is to launch the main appb interface or reveal it while rte
     * 
     * [Might also need to disable the raycasting script in this file before the main interface becomes active]
     * 
     */

    //_____________________________________REFERENCE FILES_________________________________//

    //_____________________________________________________________________________________//
    
    public GameObject StartInterface;
    public GameObject ScreenInterface;

    public void UILaunch()
    {
        StartInterface.SetActive(true);
        ScreenInterface.SetActive(false);
    }

}
