using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlScene4 : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset ; 
    }
}
// -0.35 3.88 -4.85