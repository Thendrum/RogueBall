using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class saveScene : MonoBehaviour
{
    public static saveScene instance;
    public string _lastSceneName;
    private void Start()
    {
        instance = this;
        SetSceneName();
        DontDestroyOnLoad(this.gameObject);
    }
    public void SetSceneName()
    {
        _lastSceneName = SceneManager.GetActiveScene().name;
        
    }

    
}

