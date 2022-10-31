using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Declare Variables//
    public float health;
   
    //Update Is Called Once Per Frame//
    void Update()
    {
        DisableOnDeath();
    }

    public void DisableOnDeath()
    {
        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
