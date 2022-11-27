using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class wonScreenScript : MonoBehaviour
{
    private string _lastSceneName;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        if(GetSceneName() == "Level_1")
        {
            SceneManager.LoadScene("Level_2");
        }
        if (GetSceneName() == "Tutorial")
        {
            SceneManager.LoadScene("Level_1");
        }
        if (GetSceneName() == "Level_2")
        {
            SceneManager.LoadScene("GameEnd");
        }

    }
    public void QuitGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public string GetSceneName()
    {
        _lastSceneName = saveScene.instance._lastSceneName;
        return _lastSceneName;
    }
}
