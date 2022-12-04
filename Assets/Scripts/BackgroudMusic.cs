using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudMusic : MonoBehaviour
{
    public AudioSource source;
    public int numberOfClassObjects;
    // Start is called before the first frame update
    void Start()
    {
        numberOfClassObjects = GameObject.FindGameObjectsWithTag("music").Length;
        Debug.Log(numberOfClassObjects);
        source = this.GetComponent<AudioSource>();
        if(numberOfClassObjects <= 1)
        {
            source.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        numberOfClassObjects = GameObject.FindGameObjectsWithTag("music").Length;
        DontDestroyOnLoad(this);
    }
}
