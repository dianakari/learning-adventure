using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pez3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //  AudioController.obj.playCoin();
            UIManager.obj.hidePanelPreg3(); // pregunta
                       //UIManager.obj.hidePanelPreg2(); // pregunta
                       // UIManager.obj.addScore(scoreGive);
                       // UIManager.obj.updateScore();
            Destroy(gameObject);
        }
    }
}
