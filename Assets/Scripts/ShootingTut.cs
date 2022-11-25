using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootingTut : MonoBehaviour
{
   public GameObject GunTutorial;
   public float skinWidth;

    void Update()
    {
        RaycastHit hit;
        Ray Platform = new Ray(transform.position, Vector3.up);
        if (Physics.Raycast(Platform, out hit, skinWidth))
        {
            GunTutorial.SetActive(true);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GunTutorial.SetActive(false);
        }
    }
}
