using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{// you die hear if  hit enemy and death zone
    public void OnTriggerEnter(Collider other)
    { //dead zone
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);

        }
        
       
    }
   
}
