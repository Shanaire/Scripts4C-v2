using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartitionControlScript : MonoBehaviour
{

    /* 
     * This script is to be used to control the toggling of rooms with partition sliders.
     * 
     * This is to be used so that when one room is active thats is with the partition open, the same type setup should also be active for the room without partition.
     * 
     * This is done so that a consistency can be preserved.
     * 
     */


    //______________________________________REFERENCED FILES_________________________________//

    public CameraManager CamManager;
    //_______________________________________________________________________________________//

    /* Try and keep the rooms in the same order so that it prevents any type of confusion */
    // Getting a list of rooms without Partitions
    public List<GameObject> RoomsWithParittionOpen = new List<GameObject>();
    // Getting a list of rooms with partitions
    public List<GameObject> RoomsWithPartitionClosed = new List<GameObject>();
    // Getting a list of rooms without Partitions
    public List<GameObject> RoomsWithPartitionOpenText = new List<GameObject>();
    // Getting a list of rooms with partitions
    public List<GameObject> RoomsWithPartitionClosedText = new List<GameObject>();

    // This is a list of containers that holds all the elements for when the partition is opened
    public List<GameObject> PartitionOpenContrainer = new List<GameObject>();
    // This is a list of containers that holds all the elements for when the partitions is closed
    public List<GameObject> PartitionCloseContainer = new List<GameObject>();


    public void Update()
    {
        ViewPointPartition();
    }


    // Setting Up a Partition Condition for ViewPoint Room
    public void ViewPointPartition()
    {
        /*
         * Rooms in the List run from 0 - 4
         * Room Containers from 0
         * 
         */

        // When this particular camera is active or true, run the following nested statements
        if (CamManager.CameraCount == 14)
        {

            //_____________________________________________________PARTITION CLOSED CONDITION_______________________________________________//

            // Room Nmber 1 - Partition Opened
            if (RoomsWithPartitionClosed[0].activeSelf == true && PartitionCloseContainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION CLOSED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithParittionOpen)
                {
                    if (item != RoomsWithParittionOpen[0])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionOpenText)
                {
                    if (item != RoomsWithPartitionOpenText[0])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 2 - Partition Opened
            if (RoomsWithPartitionClosed[1].activeSelf == true && PartitionCloseContainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION CLOSED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithParittionOpen)
                {
                    if (item != RoomsWithParittionOpen[1])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionOpenText)
                {
                    if (item != RoomsWithPartitionOpenText[1])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 3 - Partition Opened
            if (RoomsWithPartitionClosed[2].activeSelf == true && PartitionCloseContainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION CLOSED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithParittionOpen)
                {
                    if (item != RoomsWithParittionOpen[2])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionOpenText)
                {
                    if (item != RoomsWithPartitionOpenText[2])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }

            }
            // Room Nmber 4 - Partition Opened
            if (RoomsWithPartitionClosed[3].activeSelf == true && PartitionCloseContainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION CLOSED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithParittionOpen)
                {
                    if (item != RoomsWithParittionOpen[3])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionOpenText)
                {
                    if (item != RoomsWithPartitionOpenText[3])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 5 - Partition Opened
            if (RoomsWithPartitionClosed[4].activeSelf == true && PartitionCloseContainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION CLOSED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithParittionOpen)
                {
                    if (item != RoomsWithParittionOpen[4])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionOpenText)
                {
                    if (item != RoomsWithPartitionOpenText[4])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }






            //_____________________________________________________PARTITION CLOSED CONDITION_______________________________________________//

            // Room Nmber 1 - Partition Closed
            if (RoomsWithParittionOpen[0].activeSelf == true && PartitionOpenContrainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION OPENED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithPartitionClosed)
                {
                    if (item != RoomsWithPartitionClosed[0])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionClosedText)
                {
                    if (item != RoomsWithPartitionClosedText[0])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 2 - Partition Opened
            if (RoomsWithParittionOpen[1].activeSelf == true && PartitionOpenContrainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION OPENED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithPartitionClosed)
                {
                    if (item != RoomsWithPartitionClosed[1])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionClosedText)
                {
                    if (item != RoomsWithPartitionClosedText[1])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 1 - Partition Closed
            if (RoomsWithParittionOpen[2].activeSelf == true && PartitionOpenContrainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION OPENED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithPartitionClosed)
                {
                    if (item != RoomsWithPartitionClosed[2])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionClosedText)
                {
                    if (item != RoomsWithPartitionClosedText[2])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 2 - Partition Opened
            if (RoomsWithParittionOpen[3].activeSelf == true && PartitionOpenContrainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION OPENED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithPartitionClosed)
                {
                    if (item != RoomsWithPartitionClosed[3])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionClosedText)
                {
                    if (item != RoomsWithPartitionClosedText[3])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
            }
            // Room Nmber 1 - Partition Closed
            if (RoomsWithParittionOpen[4].activeSelf == true && PartitionOpenContrainer[0].activeSelf == true)
            {
                Debug.Log("TESTING, PARTITION OPENED");
                //RoomsWithPartitionClosed[1].SetActive(true);
                // For each item that is not the same as the item i want activate, make it deactivarted
                foreach (GameObject item in RoomsWithPartitionClosed)
                {
                    if (item != RoomsWithPartitionClosed[4])
                    {
                        item.SetActive(false);
                    }
                    else
                    {
                        item.SetActive(true);
                    }
                }
                foreach (GameObject item in RoomsWithPartitionClosedText)
                {
                    if (item != RoomsWithPartitionClosedText[4])
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
}

