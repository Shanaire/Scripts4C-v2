using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartitionRendTog : MonoBehaviour
{
    /* 
     * RATHER THAN TURNING OF THE GAMEOBJECT, FOR THE PARTITION I AM USING THE MESH RENDERER TO MAKE TH EOBJECT VISIBLE OR NOT.
     * 
     * This script is to be used to disable the mesh renderer for the partition, so that the animation does not get affected like when the game object becomes activated.
     * 
     * This needed to active when room 4 is active so when any of the cameras that room is associated with is active, the partitions also needs to be active also.
     * 
     * I need to get the Renderers from all the children objects  
     * 
     */

    //_____________________________________________REFERENCE FILES____________________________________________//

    public CameraManager CamManager;

    //________________________________________________________________________________________________________//


    Renderer[] MeshRenderers;

    private void Start()
    {
        MeshRenderers = gameObject.GetComponentsInChildren<Renderer>();
    }

    private void Update()
    {
        ViewPointPartition();
    }

    private void ViewPointPartition()
    {
        if (CamManager.CameraCount == 14 || CamManager.CameraCount == 2 || 
            CamManager.CameraCount == 10 || CamManager.CameraCount == 0)
        {
            foreach (Renderer item in MeshRenderers)
            {
                item.enabled = true;
            }
        }
        else
        {
            foreach (Renderer item in MeshRenderers)
            {
                item.enabled = false;
            }
        }
    }


}
