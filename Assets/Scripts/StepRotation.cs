using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepRotation : MonoBehaviour
{
     public float turnSpeed;
    void Update()
    {
        // I want to make this platform rotate
        transform.Rotate(new Vector3(0, turnSpeed, 0) * Time.deltaTime);
        
    }

}
