using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    /* 
     * This script is to be used to control the toggling of the rooms layouts and the text that is also associated to the specific room layout. 
     * 
     */

    public GameObject Button;
    public GameObject Title;

    public List<GameObject> Panels = new List<GameObject> ();
    public List<GameObject> TitleDeAct = new List<GameObject>();
    
    
    private bool condition = true || false;


    public void TogglePanel()
    {
   
        

        if (condition == false)
        {
            Debug.Log("---CHANGING STATUS---" + condition);

            Button.SetActive(false);
            Title.SetActive(false);
            condition = true;
        }
        else if (condition == true)
        {
            Debug.Log("---CHANGING STATUS---" + condition);

            Button.SetActive(true);
            Title.SetActive(true);

            // Setting all gameobjects in the list to inactive
            foreach (GameObject item in Panels)
               item.SetActive(false);

            foreach (GameObject item in TitleDeAct)
                item.SetActive(false);

            condition = false;
        }
    }
}






