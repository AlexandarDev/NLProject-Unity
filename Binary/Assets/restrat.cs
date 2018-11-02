using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restrat : MonoBehaviour {


	void Update () {
        if (Input.GetKey("r"))
        {
            Application.LoadLevel("SampleScene");
        }		
	}
}
