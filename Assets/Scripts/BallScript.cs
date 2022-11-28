using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 500f;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        
        
        rb.AddForce(transform.forward * thrust);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag != "Spawner")
        {
            Destroy(this.gameObject);
            Debug.Log("hit");
        }
    }
}
