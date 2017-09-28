using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPanelManager : MonoBehaviour
{
    /* 
     * This script is to be used to activate the button panels for each room corresponding to the room camera that is active 
     */

    //____________________________________________REFERENCED FILES_______________________________//

    // Referencing the Camera Manager
    public CameraManager _CamMan;
    //___________________________________________________________________________________________//

    // Assining the different Room panels to a list
    public List<GameObject> RoomPanels = new List<GameObject>();

    // Creating a private gameobject to store a reference of the object that needs to be active. 
    private GameObject _RoomPanel;

    private void Update()
    {
        PanelCondition();
    }

    void PanelCondition()
    {
        // either the main or sub cameras are active, then the panels will be switched off or false.
        if ((_CamMan.CameraCount == 1) || (_CamMan.CameraCount == 2) || (_CamMan.CameraCount == 3) || (_CamMan.CameraCount == 10))
        {
            foreach (GameObject item in RoomPanels)
            {
                item.SetActive(false);
            }
        }
        //__________ACTIVATING THE PANELS FOR THE ROOMS___________//
        // Room1
        else if (_CamMan.CameraCount == 11)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[0];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room2
        else if (_CamMan.CameraCount == 12)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[1];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room3
        else if (_CamMan.CameraCount == 13)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[2];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room4
        else if (_CamMan.CameraCount == 14)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[3];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room5
        else if (_CamMan.CameraCount == 15)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[4];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room6
        else if (_CamMan.CameraCount == 16)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[5];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // Room7
        else if (_CamMan.CameraCount == 17)
        {
            // Storing the current the panel that will become active into the variable _RoomPanel
            _RoomPanel = RoomPanels[6];

            foreach (GameObject item in RoomPanels)
            {
                if (item != _RoomPanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
    }
}
