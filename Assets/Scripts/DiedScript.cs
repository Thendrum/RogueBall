using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class DiedScript : MonoBehaviour
{
    public GameObject diedScreen;
    public GameObject gun;
    private bool isDead;
    private string name1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        diedScreen.SetActive(false);
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Died()
    {
        diedScreen.SetActive(true);
        Time.timeScale = 0f;
        gun.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isDead = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ball" || other.gameObject.name == "Lava")
        {
            Died();
        }
        

    }
    public void ReloadLevel()
    {
        name1 = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name1);
    }
}
