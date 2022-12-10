using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pulpo : MonoBehaviour
{
    public static pulpo obj; //para acceder a la clase 
   // public GameObject gameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }

  
}
