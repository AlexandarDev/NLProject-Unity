using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takebombText : MonoBehaviour {

    public string Message = "";

    void OnGUI()
    {
        GUI.Label(new Rect(450, 100, 200, 30), Message);
    }

    void OnMouseEnter()
    {
        Message = "Click to get the bomb";
    }

    void OnMouseExit()
    {
        Message = "";
    }
}
