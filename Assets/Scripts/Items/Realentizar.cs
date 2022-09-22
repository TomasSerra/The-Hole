using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Realentizar : MonoBehaviour {

    GameObject[] enemigos;
    bool realentizar;
    ActivarSliders activarSlider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(RealentizarTrue());
            Destroy(GetComponent<CircleCollider2D>());
            Destroy(GetComponent<SpriteRenderer>());
        }
        
    }

    IEnumerator RealentizarTrue()
    {
        activarSlider = GameObject.FindGameObjectWithTag("Manager").GetComponent<ActivarSliders>();
        activarSlider.SliderRealentizar();
        realentizar = true;

        enemigos = GameObject.FindGameObjectsWithTag("Enemigo");

        if (realentizar == true)
        {


            foreach (GameObject gameObjects in enemigos)
            {
                if(enemigos != null)
                {
                    gameObjects.GetComponent<MoviemientoEnemigo>().velocidad = 1f;
                }



            }
        }


        yield return new WaitForSeconds(4);

        realentizar = false;

       if (realentizar == false)
       {
            foreach (GameObject gameObjects in enemigos)
            {
                if (gameObjects != null)
                {
                    gameObjects.GetComponent<MoviemientoEnemigo>().velocidad = 2f;
                    Destroy(this.gameObject);
                }

            }
       }

    }


}
