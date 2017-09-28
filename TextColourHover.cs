using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
    public class TextColourHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    /* 
     * This script is to be used to change the colour of the text that is attacted to a button so that the colour of the text matches that of the button when hovering / highlighting.
     * 
     */
    
    // creating a varibale to hold the text cpomponent
    Text txt;
    // creating a variable to hold the base color
    Color baseColor;
    // creating a variable to hold the button component
    Button btn;
    // Boolean for the interactability of the button
    bool interactableDelay;

    void Start()
    {
        // Getting the children component of the button that is the text in this instance
        txt = GetComponentInChildren<Text>();
        // Getting the colour of the text and storing it in the variable base colour
        baseColor = txt.color;
        // Getting the Button component that the script is attached to and storing it in the variable btn. 
        btn = gameObject.GetComponent<Button>();
        // Making the boolean toggle of the interactable script on the button equal to the variable interactableDelay
        interactableDelay = btn.interactable;
    }

    void Update()
    {
        // This statement is what the button is to do if the button is not equal to the interactable delay, otherwise they equal each other.
        if (btn.interactable != interactableDelay)
        {
            if (btn.interactable)
            {
                txt.color = baseColor * btn.colors.normalColor * btn.colors.colorMultiplier;
            }
            else
            {
                txt.color = baseColor * btn.colors.disabledColor * btn.colors.colorMultiplier;
            }
        }
        interactableDelay = btn.interactable;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (btn.interactable)
        {
            txt.color = baseColor * btn.colors.highlightedColor * btn.colors.colorMultiplier;
        }
        else
        {
            txt.color = baseColor * btn.colors.disabledColor * btn.colors.colorMultiplier;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (btn.interactable)
        {
            txt.color = baseColor * btn.colors.pressedColor * btn.colors.colorMultiplier;
        }
        else
        {
            txt.color = baseColor * btn.colors.disabledColor * btn.colors.colorMultiplier;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (btn.interactable)
        {
            txt.color = baseColor * btn.colors.highlightedColor * btn.colors.colorMultiplier;
        }
        else
        {
            txt.color = baseColor * btn.colors.disabledColor * btn.colors.colorMultiplier;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (btn.interactable)
        {
            txt.color = baseColor * btn.colors.normalColor * btn.colors.colorMultiplier;
        }
        else
        {
            txt.color = baseColor * btn.colors.disabledColor * btn.colors.colorMultiplier;
        }
    }

}