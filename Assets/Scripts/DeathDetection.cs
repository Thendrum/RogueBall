using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetection : MonoBehaviour
{
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        this.GetComponent<DiedScript>().Died();
        
    }
}
