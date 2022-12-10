using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgarrarMonedas : MonoBehaviour
{
    public Text puntos;
    public Text scoreGive;
    public int monedas;
    public int live;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       puntos.text = monedas.ToString();
       // scoreGive.text = live.ToString();
       
    }

    public void agarrar ()
    {
        monedas += 20; //suma monedas
       // live += 30; //suma de vidas
    }
}
