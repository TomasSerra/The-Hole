using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movimiento : MonoBehaviour {

    public int velocidad;
    public GameObject gameOver;
    public GameObject Mascara;
    public Text textoPuntos;
    public GameObject fondo;
    public GameObject mascaraGrande;
    public Monedas monedasScript;
    public GameObject sliderAgrandarVision;
    public GameObject sliderRealentizar;
    public GameObject sliderEscudo;
    public GameObject vidaAdentro;
    public GameObject vidas;
    public GameObject sangre;
    public GameObject escudo;
  

    //Inputs input;
    //float valorHorizontal;
    Rigidbody2D miRigidbody;
    public bool muerto;
    int vida;


    private void Start()
    {
        vida = 2;
        muerto = false;
        //input = GetComponent<Inputs>();
        miRigidbody = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
        mascaraGrande.SetActive(false);
        Mascara.SetActive(true);
        textoPuntos.enabled = true;
        fondo.SetActive(true);
        vidaAdentro.SetActive(true);
        vidas.SetActive(true);

    }


    void FixedUpdate ()
    {
        if(muerto == false)
        {
            //valorHorizontal = input.horizontal;
            //Vector2 vectorVelocidad = new Vector2(valorHorizontal, 0) * velocidad;
            //miRigidbody.velocity = vectorVelocidad;

            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.y = -3.56f;
                transform.position = touchPosition;
            }
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            
            vida = vida - 1;

            if(vida == 1)
            {
                vidaAdentro.SetActive(false);
                sangre.SetActive(true);

            }

            else if (vida == 0)
            {
                muerto = true;
                miRigidbody.velocity = new Vector2(0, 0);
                gameOver.SetActive(true);
                Mascara.SetActive(false);
                textoPuntos.enabled = false;
                fondo.SetActive(false);
                mascaraGrande.SetActive(true);
                sliderAgrandarVision.SetActive(false);
                sliderRealentizar.SetActive(false);
                vidas.SetActive(false);
                sliderEscudo.SetActive(false);
                escudo.SetActive(false);
            }

        }



        if (other.CompareTag("Moneda"))
        {
            monedasScript.SumarMonedas();
        }

    }


       

    
}
