using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartitionButtonActivation : MonoBehaviour
{

    /* 
     * This script is to be used so that when the camera for the room which has a partition is not active, then the button will be deactivated.
     * 
     */

    //_________________________________REFERENCE FILES_________________________________________//
    public CameraManager CamManager;
    //________________________________________________________________________________________//

    private Button CurrentButton;

    private void Start()
    {
        CurrentButton = GetComponent<Button>();
    }

    private void Update()
    {
        PartitionButtonToggle();
    }

    public void PartitionButtonToggle()
    {
        // Viewpoint Camera = cameraCount == 14
        if (CamManager.CameraCount != 14)
        {
            CurrentButton.interactable = false;
        }
        else
        {
            CurrentButton.interactable = true;
        }
    }
}
