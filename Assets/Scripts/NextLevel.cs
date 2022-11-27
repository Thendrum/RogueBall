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
       if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if (hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name != "Level_2")
            {
                SceneManager.LoadScene("win");
            }
            else if(hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name == "Level_2")
            {
                SceneManager.LoadScene("GameEnd");
            }
            else
            {
                return;
            }
        }
    }
    

}
