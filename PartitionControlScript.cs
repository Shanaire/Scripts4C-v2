using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartitionControlScript : MonoBehaviour {

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

    // Getting a list of rooms without Partitions
    public List<GameObject> RoomsWithParittionOpen = new List<GameObject>();
    // Getting a list of rooms with partitions
    public List<GameObject> RoomsWithPartitionClosed = new List<GameObject>();



    // Setting Up a Partition Condition for ViewPoint Room
    public void ViewPointPartition()
    {
        if (Cam)

    }
}
