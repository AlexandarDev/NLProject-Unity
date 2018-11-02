using System.Collections;
using UnityEngine;

public class changecolor : MonoBehaviour {

    public Color colorchange;
    Color originColor;



	void Start () {

        originColor = gameObject.GetComponent<MeshRenderer>().material.color;
	}

    void OnMouseEnter()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = colorchange;
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = originColor;
    }


}
