using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Submarino : MonoBehaviour
{
    public static Submarino obj; //para acceder a la clase 


    public int lives = 3; // variable publica del personaje, sirve para ver el numero de vidas
                          //  public float maxLives = 3; //maximo de vidas permitidas por el personaje
                          //  public int health = 5;


    public bool isGrounded = false; //variable publica que indica que el personaje esta tocando el piso
    public bool isMooving = false;  //variable publieca que indica que el personaje se mueve 
    public bool isImmune = false;  // variable publica que indica que el personaje, sirve para controlar 

    public float speed = 5f; // variable publica que indica la velocidad de desplazamiento
    public float movHor;  //variable publica que controla el movimiento horizontal del personaje
    public float movVer;  //variable publica que controla el movimiento vertical del personaje

    public LayerMask groundLayer; // variable publica, sirve para ver si realmente esta tocando el piso

    public float radius = 0.3f; // variable publica, sirve para ver si realmente esta tocando el piso
    public float groundRayDist = 0.5f;// variable publica, sirve para ver si realmente esta tocando el piso

    private Rigidbody2D rb; //variable para acceder a los componentes
    private Animator anim; //variable para acceder a los componentes 
    private SpriteRenderer spr; //variable para acceder a los componentes
    private Vector2 moveInput;
    private float horizontal;
    private float vertical;

    public GameObject deadSub;

    void Awake() //funcion propia de unity, se debe ejecutar antes de la funcion star
    {
        obj = this; // el objeto singlenton es igual al objeto de la esecna
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //variable para tener acceso a los propiedades Rigidbody
        anim = GetComponent<Animator>();  //variable para tener acceso a los propiedades de Animator
        spr = GetComponent<SpriteRenderer>(); //variabale para tener acceso a los propiedades de SpriteRenderer
                                              //   lives = maxLives;
    }


    // Update is called once per frame
    void Update()
    {
        if (UIManager.obj.gamePause)
        {
            moveInput = new Vector2(0.0f, 0.0f);
            return;
        }
        float moveX = Input.GetAxisRaw("Horizontal"); //avanza de manera horizontal
        float moveY = Input.GetAxisRaw("Vertical"); //avanza de manera vertical
        moveInput = new Vector2(moveX, moveY);



    }


    void FixedUpdate() //variable para todo lo que tenga que ver con fisica 
    {

        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }



    //public void getDamage()
    //{
    //       lives--; //decrementar el numero de vidas 

    //       if (lives <= 0)
    //       {
    //           UIManager.obj.updateLives();
    //           this.gameObject.SetActive(false); //si llega a 0 el 0bjeto se desabilita

    //       }

    //   
    //}

    public void Hit()
    {

        if (lives <= 0)
        {
            return;
        }
        lives--;
        UIManager.obj.updateLives();
        if (lives == 0.0)
        {
            this.gameObject.SetActive(false);//si llega a 0 el 0bjeto se desabilita
            UIManager.obj.gamePause = true;
            if (UIManager.obj.gamePause)
            {
                moveInput = new Vector2(0.0f, 0.0f);
                Instantiate(deadSub, transform.position, Quaternion.identity);
                return;
               
            }
        
        }


    }



    public void addLive()
    {
        lives++; //aumenta en 1 las vidas

        if (lives > UIManager.obj.maxLives) //no pueden ser mas de las definidas en la clase
        {
            lives = UIManager.obj.maxLives; //Seran iguales al maximo
        }
    }



    void OnDestroy()
    {
        obj = null; // el objeto de singlenton es igual a nulo
    }


}

