using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PauseMenu1 : MonoBehaviour
{
    public GameObject menu;
    
    
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
        if (isPaused == false & Cursor.visible != true)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (isPaused == true & Cursor.visible == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }
    public void TogglePauseGame()
    {
        //pause time
        isPaused = !isPaused;

        //menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
            //GameManager.Instance.audio.pitch = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1f;
            //GameManager.Instance.audio.pitch = 1f;
            

        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
