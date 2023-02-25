using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float smth;
    
    void FixedUpdate()
    {
        Vector3 delayedPos = Vector3.Lerp(transform.position, Target.position, smth);
        transform.position = delayedPos + Offset;
    }
}
