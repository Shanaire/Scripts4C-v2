using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraManager : MonoBehaviour
{
    /* THINGS THAT ARE CONTROLLED IN THIS SCRIPT
     * 
     * [CAMERA TRANSITION]
     * [CAMERA SWITCHING]
     * [RAY CASTING]
     * 
     * 
     * 
     * [Working on fading between different positions]
     * 
     * 
     * Then work out how to switch the camera from the current one back to the previous camera.
     * 
     * The next step now is to reverse the transition when the back button is pressed, with this whoever, the camera goes back to the main cameras initial position, 
     * and change the active camera back to the main camera
     * 
     * Currently this script can transition to different camera position then after a specific condition is meet, it will then swap to a different camera.
     * 
     * This script is to be used to control the camera behaviour in the scene
     * 
     * It will be used to control, which cameras needs to be turned on or off depending on the whats needs to be scene.
     * 
     * It will also control the transition interpolation between the different cameras.
     * 
     * It will also need to control the firing of the raycast from the current selected camera
     * 
     * */

    #region REFERENCED SCRIPTS

    public BoolForCentrePanels BoolForCenPan;

    // Referencing the fading script
    public FadeToCamPos FadeToCam;

    #endregion

    int PrevCamCount;
    private Vector3 MousePosition;

    // Camera and initial camera empty position
    public GameObject MainCam; public GameObject MainCam_INS;
    public Transform InitialCamPosition;

    // Camera Component Reference
    private Camera ActiveCamera;
    //private Transform CurrentTransform;

    public int CameraCount = 0;
    public int TransitionCode = 0;

    // Sub Section Cameras to deactive
    public List<GameObject> SubCams = new List<GameObject>();
    private List<Transform> SubCam_ = new List<Transform>();
    public List<Transform> TransitionPointsToSub = new List<Transform>();

    // Room cameras to deactivte
    public List<GameObject> RoomCams = new List<GameObject>();
    private List<Transform> RoomCam_ = new List<Transform>();
    public List<Transform> TransitionPointsToRoom = new List<Transform>();

    // FADING CAMERA WHILE THE CAMERA IS TRANSITIONING.
    //public float TransitionSpeed = 2.0f; // NOT BEING USED    

    private void Start()
    {
        // Initializing the Active Camera as the main camera
        ActiveCamera = MainCam.GetComponent<Camera>();
    }

    public void Update()
    {
        RayCasting();
    }

    private void LateUpdate()
    {
        CameraSwitching();
    }

    public void CameraSwitching()
    {
        // Sub Cameras being added to a private group getting there Transform properties
        SubCam_.Add(SubCams[0].gameObject.GetComponent<Transform>());
        SubCam_.Add(SubCams[1].gameObject.GetComponent<Transform>());
        SubCam_.Add(SubCams[2].gameObject.GetComponent<Transform>());

        //Room Cameras to switch to, getting there trasform properties
        RoomCam_.Add(RoomCams[0].gameObject.GetComponent<Transform>());
        RoomCam_.Add(RoomCams[1].gameObject.GetComponent<Transform>());
        RoomCam_.Add(RoomCams[2].gameObject.GetComponent<Transform>());

        #region CHANGE_TO_SUB_CAMERAS


        if (CameraCount == 1)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 1;
            ActiveCamera.enabled = false;
            MainCam = SubCams[0];

            if (MainCam == SubCams[0])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 1;
            }
        }
        // Change to sub camera 2
        else if (CameraCount == 2)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = SubCams[1];

            if (MainCam == SubCams[1])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 2;
            }
        }
        // Change to sub camera 3
        else if (CameraCount == 3)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = SubCams[2];

            if (MainCam == SubCams[2])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 3;
            }
        }
        #endregion
        #region SUBSECTION_ROOMS

        // SubSection 1 Rooms
        // Individual Room 1 Cameras, switching cameras 
        if (CameraCount == 11)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[0];

            if (MainCam == RoomCams[0])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 11;
            }
        }
        // Individual Room 2 Cameras, switching cameras 
        else if (CameraCount == 12)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[1];

            if (MainCam == RoomCams[1])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 12;
            }
        }
        // Individual Room 3 Cameras, switching cameras
        else if (CameraCount == 13)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[2];

            if (MainCam == RoomCams[2])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 13;
            }
        }
        // SubSection 2 Rooms
        // Individual Room 4 Cameras, switching cameras
        else if (CameraCount == 14)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 2;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[3];

            if (MainCam == RoomCams[3])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 14;
            }
        }
        // Individual Room 5 Cameras, switching cameras
        else if (CameraCount == 15)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 2;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[4];

            if (MainCam == RoomCams[4])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 15;
            }
        }
        // Individual Room 6 Cameras, switching cameras
        else if (CameraCount == 16)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 2;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[5];

            if (MainCam == RoomCams[5])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 16;
            }
        }
        // SubSection 3 Rooms
        // Individual Room 7 Cameras, switching cameras
        else if (CameraCount == 17)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            // Switching the Current Camera to a Sub Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = RoomCams[6];

            if (MainCam == RoomCams[6])
            {
                // Then re-assign MainCam Camera component to the new MainCam, which is the switched camera and then Set it to Active
                // Number to activate the point transition
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 17;
            }
        }

        // Moving Back to the initial position
        else if (CameraCount == 10)
        {
            // Making the Previous Camera equalling the active camera before disabling it, so that the back function can work
            // Deactivating the Current Camera
            PrevCamCount = 10;
            ActiveCamera.enabled = false;
            MainCam = MainCam_INS;

            if (MainCam == MainCam_INS)
            {
                ActiveCamera = MainCam.GetComponent<Camera>();
                ActiveCamera.enabled = true;
                TransitionCode = 10;
            }
        }
        #endregion
    }

    public void RayCasting()
    {
        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ActiveCamera.farClipPlane);
        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ActiveCamera.nearClipPlane);

        Vector3 mousePosF = ActiveCamera.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = ActiveCamera.ScreenToWorldPoint(mousePosNear);

        RaycastHit hit;
        Ray RayToObject = new Ray(mousePosN, mousePosF);

        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && MousePosition == Input.mousePosition)
        {
            // Debug.Log("Condition Status" + BoolForCenPan.panelCondition);
            if (BoolForCenPan.panelCondition == true)
            {
                Physics.Raycast(RayToObject, 0f);
                // Debug.Log("Checking");
            }

            else if (BoolForCenPan.panelCondition == false)
            {
                Debug.DrawRay(mousePosN, mousePosF, Color.green);

                if (Physics.Raycast(RayToObject, out hit))
                {
                    // Casting a Ray for SubSection 2 and changing the Camera Count
                    if ((hit.collider.transform.tag == "Room4") || (hit.collider.transform.tag == "Room5") || (hit.collider.transform.tag == "Room6"))
                    {
                        FadeToCam.RoomFadeOUT();
                        CameraCount = 2;
                        FadeToCam.RoomFadeIN();
                    }

                    // Casting a Ray for SubSection 3 and changing the Camera Count
                    if (hit.collider.tag == "Room7")
                    {
                        FadeToCam.RoomFadeOUT();
                        CameraCount = 17;
                        FadeToCam.RoomFadeIN();
                    }

                    // Casting a Ray for the individual Room1 etc given the relevant sub camera is activated
                    // Room 1
                    if (hit.collider.tag == "Room1")
                    {
                        // I want the fade to start before this starts to change
                        FadeToCam.RoomFadeOUT();
                        CameraCount = 11;
                        FadeToCam.RoomFadeIN();

                    }

                    // Room 2
                    if (hit.collider.tag == "Room2")
                    {
                        // I want the fade to start before this starts to change
                        FadeToCam.RoomFadeOUT();
                        CameraCount = 12;
                        FadeToCam.RoomFadeIN();
                    }

                    // Room 1
                    if (hit.collider.tag == "Room3")
                    {
                        // I want the fade to start before this starts to change
                        FadeToCam.RoomFadeOUT();
                        CameraCount = 13;
                        FadeToCam.RoomFadeIN();
                    }


                    // Subsection 2 changing to one of the room cameras
                    else if (CameraCount == 2)
                    {
                        // Room 4
                        if (MainCam == SubCams[1])
                        {
                            if (hit.collider.transform.tag == "Room4")
                            {
                                FadeToCam.RoomFadeOUT();
                                CameraCount = 14;
                                FadeToCam.RoomFadeIN();
                            }
                        }

                        // Room 5
                        if (MainCam == SubCams[1])
                        {
                            if (hit.collider.transform.tag == "Room5")
                            {
                                FadeToCam.RoomFadeOUT();
                                CameraCount = 15;
                                FadeToCam.RoomFadeIN();
                            }
                        }

                        // Room 6
                        if (MainCam == SubCams[1])
                        {
                            if (hit.collider.transform.tag == "Room6")
                            {
                                FadeToCam.RoomFadeOUT();
                                CameraCount = 16;
                                FadeToCam.RoomFadeIN();
                            }
                        }
                    }
                    // Subsection 3 changing to one of the room cameras
                    else if (CameraCount == 3)
                    {
                        // Room 7
                        if (MainCam == SubCams[2])
                        {
                            if (hit.collider.transform.tag == "Room7")
                            {
                                FadeToCam.RoomFadeOUT();
                                CameraCount = 17;
                                FadeToCam.RoomFadeIN();
                            }
                        }
                    }
                }
            }
        }
    }
    // This is going to be a revse transition back to the main camera's initial position
    public void ReverseTransition()
    {
        // Create a variable to hold the previous camera position
        // Fading Camera
        // Set the current transition point to the transition position of the main camera's
        // So i need to get the last camera positition and store it in PrevCamPos. 
        // Using the previous camera count, to change the camera back to the previously chosen 
        // Setting this bool condition back to false to enable raycasting from this script
        FadeToCam.RoomFadeOUT();
        CameraCount = PrevCamCount;
        FadeToCam.RoomFadeIN();
        BoolForCenPan.panelCondition = false;
    }
}

