using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    public GameObject target;
    public float rotation = 5;
    Vector3 offset;



    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotation;
        target.transform.Rotate(0, horizontal, 0);
        float angle = target.transform.eulerAngles.y;
        Quaternion rotate = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotate * offset);
        transform.LookAt(target.transform);


    }
}


