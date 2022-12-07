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
    public GameObject lava;
    public Vector3 lavaSpawnPostion;
    public bool lavaSpawned;
    private void Start()
    {
        lavaSpawned = false;
        
        spawnerPresent = true;
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        
    }
    public void Update()
    {
       spawners = GameObject.FindGameObjectsWithTag("Spawner");
       RaycastHit hit;
       if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if (hit.collider.gameObject.name == "lavaSpawn" && lavaSpawned == false)
            {
                if(SceneManager.GetActiveScene().name != "Tutorial")
                {
                    Instantiate(lava, lavaSpawnPostion, Quaternion.identity);
                    lavaSpawned = true;
                }
                else 
                {
                    Instantiate(lava, lavaSpawnPostion + new Vector3(0, -1, 0), Quaternion.identity);
                    lavaSpawned = true;
                }

            }
            if (hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name != "Level_2" && spawners.Length == 0) 
            {
                SceneManager.LoadScene("win");
            }
            else if(hit.collider.gameObject.name == "final" && SceneManager.GetActiveScene().name == "Level_2" && spawners.Length == 0)
            {
                SceneManager.LoadScene("GameEnd");
            }
            else if (hit.collider.gameObject.name == "final" && spawners.Length > 0)
            {
                hit.collider.gameObject.GetComponent<MeshRenderer>().material = red;
            }
            else
            {
                if(hit.collider.gameObject.name == "final")
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material = yellow;
                }
                return;
            }
            
        }
    }
}
