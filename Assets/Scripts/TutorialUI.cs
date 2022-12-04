using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TutorialUI : MonoBehaviour
{
    public GameObject LavaTut;
    public GameObject LavaUI;
    public GameObject GunTut;
    public GameObject GunTutorial;
    public float skinWidth;
    public GameObject JumpTutorial;
    void Update()
    {
        //fixed?
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if (hit.collider.gameObject.name == "LavaTut")
            {
                LavaUI.SetActive(true);
            }
        else if (hit.collider.gameObject.name == "GunTut")
            {
                GunTutorial.SetActive(true);
            }
        }       


        if (Input.GetButtonDown("Jump"))
        {
            LavaUI.SetActive(false);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GunTutorial.SetActive(false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            JumpTutorial.SetActive(false);
        }
    }

   
}
