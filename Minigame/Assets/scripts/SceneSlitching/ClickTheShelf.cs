
using System.Collections;

using UnityEngine;

public class ClickTheShelf : MonoBehaviour
{

    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update(){



    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Is clicked");

            Application.LoadLevel("MiniGameScene2");
        }


    }

}
