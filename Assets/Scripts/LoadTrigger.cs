using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrigger : MonoBehaviour
{
    public int numerOfScene;
    public string playerTag;

      
     
    void OnTriggerStay2D(Collider2D other)
    {    
        Debug.Log("!");
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Quit");
                Application.Quit();
            }
        }
    }
}


