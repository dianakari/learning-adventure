using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    private Rigidbody2D rb;

    public float movHor = 1f; //movimiento horizontal 
    public float speed = 3f;  //velocidad

   // public int scoreGive = 50; //puntaje del enemigo

    public bool isGroundFloor = true; //si toca el piso
    public bool isGroundFront = false;

    public LayerMask groundLayer;  //variable especial para el piso
    public float frontGrndRayDist = 0.25f; //comportamiento del eneigo
    public float floorChecky = 0.51f;
    public float frontCheck = 0.51f;
    public float frontDist = 0.001f;

 

    //public int scoreGive = 50; //puntaje del enemigo

    private RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //asignacion del cuerpo rigido  
    }

    // Update is called once per frame
    void Update()
    {
        //evitar caer al precipicio 
        isGroundFloor = (Physics2D.Raycast(new Vector3(transform.position.x, transform.position.y - floorChecky, transform.position.z),
            new Vector3(movHor, 0, 0), frontGrndRayDist, groundLayer));

        if (isGroundFloor)
            movHor *= -1;

        //choque de paredes
        if (Physics2D.Raycast(transform.position, new Vector3(movHor, 0, 0), frontCheck, groundLayer))
            movHor *= -1; //cambia la orientacion del enemigo

        //choque con otro enemigo 
        hit = Physics2D.Raycast(new Vector3(transform.position.x + movHor * frontCheck, transform.position.y, transform.position.z),
            new Vector3(movHor, 0, 0), frontDist); //detecta choque al sentido que se mueve

        if (hit != null)
            if (hit.transform != null)
                if (hit.transform.CompareTag("Medusa")) //contiene el tag mencionado
                    movHor *= -1; //cambia a orientacion del enemigo 

    }

    void FixeUpdate()
    {
        rb.velocity = new Vector2(movHor * speed, rb.velocity.y); //maneja el moviento del enemigo
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
   // hacer daño al personaje
      if (collision.gameObject.CompareTag("Player"))
        {
            Submarino.obj.Hit(); //funcion implementada al player

            //Reiniciar.gameObject.SetActive(true);
            //GameOver.enabled = true;
        }
    }

    //Spublic void Hit()
   // {
     //   lives--;
     //   if (lives == 0)
     //  {
     //       UIManager.obj.addLive(scoreGive);
    //       UIManager.obj.updateLive();
           // AudioController.obj.playEnemy();  //se asigna uadio para cuando el enemigo brote la sangre, video45
           // Instantiate(deadEnemyP, transform.position, Quaternion.identity);   //para cuando el enemigo brote la sangre, video45
   //         Destroy(gameObject);
   //     }
   // }

}
