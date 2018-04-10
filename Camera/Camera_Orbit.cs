using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Camera_Orbit : MonoBehaviour
{
    [Tooltip("The Pivot of the Camera that we want to orbit")]
    public Transform target;

    [SerializeField]
    private List<GameObject> PivotToOrbitAround = new List<GameObject>();
    private Transform[] PivotInitialPos;

    // Current selected camera
    [SerializeField]
    private RoomCulling RoomCullingScript;
    private int CameraCount;
    private int CameraCountCheck;

    public float xSpeed = 20.0f;
    public float ySpeed = 20.0f;

    // Setting the min and max limit for the y axis
    private float yMinLimit;
    private float yMaxLimit;

    // Temporary quaternion holder
    private Quaternion _NewRot;

    [SerializeField]
    private float Damping = 2f;

    private float x = 0.0f;
    private float y = 0.0f;

    private float x_2 = 0f;
    private float y_2 = 0;

    private int counter = 0; // Camera Checker

    private bool isChanging = true;

    void Start()
    {
        PivotInitialPos = new Transform[PivotToOrbitAround.Count];

        for (int i = 0; i < PivotToOrbitAround.Count; i++)
        {
            PivotInitialPos[i] = PivotToOrbitAround[i].transform;
        }

        yMaxLimit = 90f;
        yMinLimit = 0f;


    }

    private void Update()
    {
        CameraCount = RoomCullingScript.CameraCount;

        // Getting the current selected camera number, this also does a check
        // Where is sees if the camera count check is the same as the normal camera count
        // And if it is not, then it will transition
        if (CameraCount != CameraCountCheck)
        {
            isChanging = true;
            FindingPivot();
            CameraCountCheck = CameraCount;
        }

        if (Input.touchCount == 2)
        {
            return;
        }
        else
        {
            _NewRot = GetNewRot();
        }
    }

    void LateUpdate()
    {
        if (target != null)
        {
            ApplyNewRotation(_NewRot, Damping);
        }
    }

    private void FindingPivot()
    {
        // This is finding the respective pivot based on the current selected camera
        if (isChanging && CameraCount == 1)
            do
            {
                ObjectAndCameraCount(1, 7);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 5)
            do
            {
                ObjectAndCameraCount(5, 0);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 6)
            do
            {
                ObjectAndCameraCount(6, 1);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 7)
            do
            {
                ObjectAndCameraCount(7, 2);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 3)
            do
            {
                ObjectAndCameraCount(3, 8);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 8)
            do
            {
                ObjectAndCameraCount(8, 3);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 9)
            do
            {
                ObjectAndCameraCount(9, 4);
                isChanging = false;
            } while (isChanging == true);

        if (isChanging && CameraCount == 10)
            do
            {
                ObjectAndCameraCount(10, 5);
                isChanging = false;
            } while (isChanging == true);


    }

    // Setting the pivot x and y eulerAngles to allow rotation for the new selected camera
    private void ObjectAndCameraCount(int CameraCountNumber, int PivotIndex, int[] Numers = null)
    {
        if (CameraCount == CameraCountNumber) // & counter == 0)
        {
            target = PivotToOrbitAround[PivotIndex].transform;

            x = PivotToOrbitAround[PivotIndex].transform.eulerAngles.y;
            y = PivotToOrbitAround[PivotIndex].transform.eulerAngles.x;
        }
    }

    #region ROTATION LERPING
    // Getting the new rotation then applying the rotation. 

    // Using the Movement whether mouse or touch to orbit the camera
    Quaternion GetNewRot()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            if (target)
            {
                float Touch_1_x = Input.GetTouch(0).deltaPosition.x;
                float Touch_1_y = Input.GetTouch(0).deltaPosition.y;

                // float Touch_2_x = Input.GetTouch(0).position.x;
                // float Touch_2_y = Input.GetTouch(0).position.y;

                x += Touch_1_x * xSpeed * 0.02f * 0.003f;
                y -= Touch_1_y * ySpeed * 0.02f * 0.003f;

                y = ClampAngle(y, yMinLimit, yMaxLimit);
            }
        }
        Quaternion newRotation = Quaternion.Euler(y, x, 0);

        return newRotation;
    }

    void ApplyNewRotation(Quaternion NewRotation, float Damping)
    {
        target.transform.rotation = Quaternion.Lerp(target.transform.rotation, NewRotation, Time.deltaTime * Damping);
    }

    #endregion


    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}