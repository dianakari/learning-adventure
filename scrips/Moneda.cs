using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{

    public GameObject mon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") //compara el objeto player 
        {
            other.gameObject.GetComponent<AgarrarMonedas>().agarrar();  //toma la moneda a traves el metodo agarar moneda
            Instantiate(mon, transform.position, Quaternion.identity);
            Destroy(gameObject); //destruye el objeto

        }
    }
}
