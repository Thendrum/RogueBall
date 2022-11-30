using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TutorialUI : MonoBehaviour
{
    public GameObject LavaUI;
    public float skinWidth;
    public GameObject JumpTutorial;
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            JumpTutorial.SetActive(false);
        }
        
        //Probably better to cast the ray from the player but this is the way I did it
        //Ray casts upwards from the object 
        RaycastHit hit;
        Ray Platform = new Ray(transform.position, Vector3.up);
        if (Physics.Raycast(Platform, out hit, skinWidth))
        {
            LavaUI.SetActive(true);
        }

        if (Input.GetButtonDown("Jump"))
        {
            LavaUI.SetActive(false);
        }
    }

   
}
