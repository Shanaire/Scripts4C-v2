﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerDeAct : MonoBehaviour
{
    /* 
     * This script is to be used to control the animatioin of the partition doors when it is changing states from open to closed.
     * 
     */

    // A list of elements that require the partition if is open 
    public List<GameObject> WithOutPartitionElements = new List<GameObject>();
    /*
     * - Layout With Partitions (Furniture)
     * - Panel - with Partitions (Activating or Deactivating the Button)
     * - Room Names Panel in the Top right hand of the screen (Room Names)
     * 
     */

    // A list of elements that require the partition if is closed
    public List<GameObject> WithPartitionElements = new List<GameObject>();
    /* 
     * - Layout WithOut Partitions (Furniture)
     * - Panel - withOut Partitions (Activating or Deactivating the Button)
     * - Room Names Panel in the Top right hand of the screen (Room Names)
     * 
     */

    bool partitionOpen;
    bool condition;

    public void DoorController()
    {

        if (partitionOpen == true)
        {
            this.GetComponent<Animator>().SetTrigger("open");
            partitionOpen = false;
            Debug.Log(partitionOpen);
            condition = true;

            if (condition == true)
            {
                Debug.Log("---CHANGING STATUS---" + condition);

                foreach (GameObject item in WithPartitionElements)
                    item.SetActive(true);

                foreach (GameObject item in WithOutPartitionElements)
                    item.SetActive(false);

                condition = false;
            }

        }
        else if (partitionOpen == false)
        {
            this.GetComponent<Animator>().SetTrigger("closed");
            partitionOpen = true;
            Debug.Log(partitionOpen);

            if (condition == false)
            {
                Debug.Log("---CHANGING STATUS---" + condition);

                // Setting all gameobjects in the list to inactive

                foreach (GameObject item in WithPartitionElements)
                    item.SetActive(false);

                foreach (GameObject item in WithOutPartitionElements)
                    item.SetActive(true);
                condition = true;
            }
        }


    }

}
