using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pez : MonoBehaviour
{
    //public int scoreGive = 50;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          //  AudioController.obj.playCoin();
            UIManager.obj.hidePanelPreg(); // pregunta
            //UIManager.obj.hidePanelPreg2(); // pregunta
           // UIManager.obj.addScore(scoreGive);
           // UIManager.obj.updateScore();
           Destroy(gameObject);
        }
    }
}
