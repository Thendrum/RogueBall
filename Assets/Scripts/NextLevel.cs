using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject finalPlatform;
    public float skinWidth;
    public bool Win;

    public void Update()
    {
       RaycastHit hit;
       Ray PlatformRay = new Ray(transform.position, Vector3.up);
       if(Physics.Raycast(PlatformRay, out hit, skinWidth))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    

}
