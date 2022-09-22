using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {


    public Transform[] spawner;
    public GameObject[] enemigo;
    int tiempo;
    public static EnemySpawn Personaje;

    GameObject personaje;
    Movimiento movimientoPersonaje;
    float contador = 0f;
    int enemyIndex;

    void Start () {

        Personaje = this;

        personaje = GameObject.FindGameObjectWithTag("Player");
        movimientoPersonaje = personaje.GetComponent<Movimiento>();

        NuevoEnemigo();
	}

    void Update()
    {
        contador = contador + Time.deltaTime;
    }


    void NuevoEnemigo()
    {


        if(contador <= 15f)
        {

             tiempo = Random.Range(6, 9);
             enemyIndex = 0;
           
        }
        else if (contador > 15f && contador <= 40f )
        {

             tiempo = Random.Range(5, 6);
             enemyIndex = Random.Range(0, 1);
           
        }
        else if (contador > 40f)
        {

             tiempo = Random.Range(4, 5);
            enemyIndex = Random.Range(0, enemigo.Length );
        }


        Invoke("Spawn", tiempo);

    }


    void Spawn () {
		if(movimientoPersonaje.muerto == false)
        {

            int spawnerIndex = Random.Range(0, spawner.Length);
            Instantiate(enemigo[enemyIndex], spawner[spawnerIndex].position, spawner[spawnerIndex].rotation);
            NuevoEnemigo();

        }
    }
}
