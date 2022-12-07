using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableBox : MonoBehaviour
{
    public int currentHealth = 3;
    public GameObject barrel;
    public Material red;
    public Material yellow;

   
    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth == 2)
        {
            barrel.GetComponent<MeshRenderer>().material = yellow;
            this.GetComponent<MeshRenderer>().material = yellow;
        }
        if (currentHealth == 1)
        {
            barrel.GetComponent<MeshRenderer>().material = red;
            this.GetComponent<MeshRenderer>().material = red;
        }
        //this.GetComponent<MeshRenderer>().material.color = boxColor;
        //barrelGetComponent<MeshRenderer>().material.color = barrelColor;
        if (currentHealth <= 0)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
