using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    public int scene;
  public GameObject transition;
    public GameObject canvasGameOver;
    //public GameObject virtualControls;

    void Update()
    {
        if (Submarino.obj.lives == 0)
        {
            //AudioController.obj.playExit();
           transition.SetActive(true);
            //canvas.SetActive(false);
            canvasGameOver.SetActive(true);
         //   virtualControls.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           // AudioController.obj.playExit();
            transition.SetActive(true);
            Invoke("ChangeLevel", 5.0f);
        }
    }

    public void ChangeLevel()
    {
        SceneManager.LoadScene(scene);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Salir del juego");
    }
}
