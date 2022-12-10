using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    private Animator transitionAnmator;

 //   void star ()
 //    {
 //       transitionAnmator = GetComponentInChildren<Animator>();
 //    }
        
   //para el primer boton de jugar 
   public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //para cambiar del menu principal a la primera escena
        
    }

  //  public IEnumerator SceneLoad ()
 // {
 //      transitionAnmator.SetTrigger("StartTransition");
 //       yield return new WaitForSeconds(1f);
 //       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 //   }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
