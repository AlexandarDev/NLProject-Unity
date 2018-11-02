using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterScene3 : MonoBehaviour {

    private float timer = 10f;


	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        Debug.Log(timer);
        if (timer<=8.5) {
            Application.LoadLevel("MiniGameScene3");
        }
	}
}
