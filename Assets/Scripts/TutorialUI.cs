using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TutorialUI : MonoBehaviour
{
    
    public GameObject JumpTutorial;
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            JumpTutorial.SetActive(false);
        }
    }
}
