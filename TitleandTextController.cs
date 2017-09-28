using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleandTextController : MonoBehaviour
{

    /* 
     * This script is to control the main Title text and the Body text using the Different Cameras active camera. 
     * 
     */

    //_________________________________REFERENCED FILES______________________________//

    public CameraManager CamManager;

    //_______________________________________________________________________________//

    public List<GameObject> TitlePanel =  new List<GameObject>();
    private GameObject _TitlePanel;

    private void Update()
    {
        TitleTrigger();
    }

    void TitleTrigger()
    {
        Debug.Log("This is title trigger");

        // Starting Camera 
        if (CamManager.CameraCount == 1)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[0];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }

        }
        // This camera count uses when fading back to the main camera
        else if (CamManager.CameraCount == 10)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[0];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Subsection 2
        else if (CamManager.CameraCount == 2)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[0];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Subsection 3
        else if (CamManager.CameraCount == 3)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[0];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 1
        else if (CamManager.CameraCount == 11)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[1];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 2
        else if (CamManager.CameraCount == 12)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[2];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 3
        else if (CamManager.CameraCount == 13)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[3];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 4
        else if (CamManager.CameraCount == 14)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[4];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 5
        else if (CamManager.CameraCount == 15)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[5];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 6
        else if (CamManager.CameraCount == 16)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[6];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
                {
                    item.SetActive(false);
                }
                else
                {
                    item.SetActive(true);
                }
            }
        }
        // This is what will become active when fading to Room 7
        else if (CamManager.CameraCount == 17)
        {
            // Storing the current active panel into the _TitlePanel variable
            _TitlePanel = TitlePanel[7];

            foreach (GameObject item in TitlePanel)
            {
                // If the item is not equal the item stored in _TitlePanel then it will be set to active 
                if (item != _TitlePanel)
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
