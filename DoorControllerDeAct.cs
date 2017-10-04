using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerDeAct : MonoBehaviour
{
    /* 
     * This script is to be used to control the animatioin of the partition doors when it is changing states from open to closed.
     * 
     */

    //______________________________________________REFERENCE SCRIPTS_____________________________________//

    public CameraManager CamManager;

    //____________________________________________________________________________________________________//




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

    public void ViewPointDoor()
    {
        if (CamManager.CameraCount == 14)
        {
            DoorController();
        }
    }

    void ConditionTruePartition()
    {
        //Debug.Log("---CHANGING STATUS---" + condition);

        foreach (GameObject item in WithPartitionElements)
            item.SetActive(true);

        foreach (GameObject item in WithOutPartitionElements)
            item.SetActive(false);
    }

    void ConditionFalsePartition()
    {
        //Debug.Log("---CHANGING STATUS---" + condition);

        // Setting all gameobjects in the list to inactive

        foreach (GameObject item in WithPartitionElements)
            item.SetActive(false);

        foreach (GameObject item in WithOutPartitionElements)
            item.SetActive(true);
    }


    private void DoorController()
    {

        if (partitionOpen == true)
        {
            this.GetComponent<Animator>().SetTrigger("open");
            partitionOpen = false;
            //Debug.Log(partitionOpen);

            // Add a delay timer here so that the animation finishes before ,making the room elements become active.

            condition = true;

            if (condition == true)
            {
                ConditionTruePartition();

                condition = false;
            }

        }
        else if (partitionOpen == false)
        {
            this.GetComponent<Animator>().SetTrigger("closed");
            partitionOpen = true;
            //Debug.Log(partitionOpen);

            // Add a delay timer here so that the animation finishes before ,making the room elements become active.

            if (condition == false)
            {
                Invoke("ConditionFalsePartition", 2.5f);
                condition = true;
            }
        }


    }

}
