using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject ball;
    public bool spawnBalls = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine()
    {
        while (spawnBalls == true)
        {
            yield return new WaitForSeconds(.5f);
            Vector3 spawnPos = this.transform.position;
            Instantiate(ball, spawnPos, this.transform.rotation);
            
        }
    }
}
