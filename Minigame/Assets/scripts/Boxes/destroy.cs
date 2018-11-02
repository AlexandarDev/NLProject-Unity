using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject box;
   
 

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (this.gameObject.tag == "kutiq") ;
            Destroy(this.gameObject);
        }


    }
}