using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupTextScript : MonoBehaviour {

    public GameObject text;
 
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        text.SetActive(true);
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        text.SetActive(false);
    }
}
