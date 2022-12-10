using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour
{
    public static Barco obj; //para acceder a la clase 

    //public Slider sliderVidas;
    public int lives = 3; // variable publica del personaje, sirve para ver el numero de vidas

    public bool isGrounded = false; //variable publica que indica que el personaje esta tocando el piso
    public bool isMooving = false;  //variable publieca que indica que el personaje se mueve 
    public bool isImune = false;  // variable publica que indica que el personaje, sirve para controlar 

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


    //barra de vida
    //private void OnCollisionEnter2D(Collision2D other)
   // {
    //    if (other.gameObject.CompareTag("Medusa")) //comprara el obejto con el enemigo
     //   {
     //       lives--;
     //       sliderVidas.value = lives;
     //   }

      //  if (lives <= 0)
     //   {
      //      Destroy(this.gameObject);
     //   }

   // }

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //variable para tener acceso a los propiedades Rigidbody
        anim = GetComponent<Animator>();  //variable para tener acceso a los propiedades de Animator
        spr = GetComponent<SpriteRenderer>(); //variabale para tener acceso a los propiedades de SpriteRenderer
        //sliderVidas.maxValue = lives;  //numero maximmo de vidas
        //sliderVidas.value = sliderVidas.maxValue; 
    }

    // Update is called once per frame
    void Update()
    {
       
       float moveX = Input.GetAxisRaw("Horizontal"); //avanza de manera horizontal
       float moveY = Input.GetAxisRaw("Vertical"); //avanza de manera vertical
       moveInput = new Vector2(moveX, moveY);   
    }

    

    private void flip(float _xValue) //la funcion recibe un valor en xsi este es menor a 0
    {
        Vector3 theScale = transform.localScale;

        if (-_xValue < 0)
            theScale.x = Mathf.Abs(theScale.x) * -1;
        else
            if (_xValue > 0)
            theScale.x = Mathf.Abs(theScale.x) * 1;

        transform.localScale = theScale;

    }


    void FixedUpdate() //variable para todo lo que tenga que ver con fisica 
    {
       
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }

    void Awake() //funcion propia de unity, se debe ejecutar antes de la funcion star
    {
        obj = this; // el objeto singlenton es igual al objeto de la esecna
    }

    public void getDamage()
    {
        lives--; //decrementar el numero de vidas 
        if (lives <= 0)
            this.gameObject.SetActive(false); //si llega a 0 el 0bjeto se desabilita
    }


}
