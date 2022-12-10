using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject submarino;

    // Update is called once per frame
    void Update()
    {
        if (submarino != null)
        {
            Vector3 position = transform.position;
            position.x = submarino.transform.position.x;
            // position.y = submarino.transform.position.y;
            transform.position = position;
        }
    }
    //transform.position = new Vector3(submarino.transform.position.x, submarino.transform.position.y, transform.position.z);

    //Vector3 position = transform.position;
    //position.x = submarino.transform.position.x; //sigue la posicion del player
    // position.y = submarino.transform.position.y;
    //transform.position = position;  

}
