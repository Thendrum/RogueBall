using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject finalPlatform;
    public float skinWidth;
    public bool Win;
    public bool spawnerPresent;
    public GameObject[] spawners;
    public Material red;
    public Material yellow;
    private void Start()
    {
        spawnerPresent = true;
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
    }
    public void Update()
    {
       
       RaycastHit hit;
       if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if (hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name != "Level_2" && spawners[0] == null) 
            {
                SceneManager.LoadScene("win");
            }
            else if(hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name == "Level_2" && spawners[0] == null)
            {
                SceneManager.LoadScene("GameEnd");
            }
            else if (hit.collider.gameObject.name == "final" && spawners[0] != null)
            {
                hit.collider.gameObject.GetComponent<MeshRenderer>().material = red;
            }
            else
            {
                hit.collider.gameObject.GetComponent<MeshRenderer>().material = yellow;
                return;
            }
        }
    }
    

}
