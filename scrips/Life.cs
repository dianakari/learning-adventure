using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public int scoreGive = 30; //agrega puntos al score


    public GameObject vid;

    void OnTriggerEnter2D(Collider2D collision) //Permitira atravesar al personaje
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Submarino.obj.addLive();
            UIManager.obj.updateLives();
            Instantiate(vid, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }


}