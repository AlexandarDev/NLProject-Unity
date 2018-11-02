using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeBomb : MonoBehaviour {

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Is clicked");

            Application.LoadLevel("MiniGameScene4");
        }


    }
}
