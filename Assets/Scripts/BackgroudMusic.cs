using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudMusic : MonoBehaviour
{
    public AudioSource music;
    int amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = GameObject.FindGameObjectsWithTag("music").Length;
        if(amount <= 1)
        {
            music.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        amount = GameObject.FindGameObjectsWithTag("music").Length;
        DontDestroyOnLoad(this);
    }
}
