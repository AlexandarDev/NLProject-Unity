
using UnityEngine;

public class followplayer : MonoBehaviour
{


    public Transform PlayerTransform;
    public Vector3 offset;


    void Update()
    {
        transform.position = PlayerTransform.position + offset;

    }
}
