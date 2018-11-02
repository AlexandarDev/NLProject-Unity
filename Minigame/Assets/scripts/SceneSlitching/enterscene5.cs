using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterscene5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private float timer = 10f;




    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);
        if (timer <= 5.2)
        {
            Application.LoadLevel("MiniGameScene5");
        }
    }
}
