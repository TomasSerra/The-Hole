using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour {

    public Transform[] spawner;
    public GameObject[] items;
    int tiempo;

    Movimiento personaje;
    float contador = 0f;
    int itemIndex;

    void Start()
    {

        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
        NuevoItem();
    }

    void Update()
    {
        contador = contador + Time.deltaTime;

    }


    void NuevoItem()
    {
        itemIndex = Random.Range(0, items.Length);

        if (contador < 20f)
        {
            tiempo = Random.Range(15, 20);

        }
        else if (contador >= 20f)
        {
            tiempo = Random.Range(12, 18);

        }

        Invoke("Spawn", tiempo);
    }


    void Spawn()
    {
        if (personaje.muerto == false)
        {

            int spawnerIndex = Random.Range(0, spawner.Length);
            Instantiate(items[itemIndex], spawner[spawnerIndex].position, spawner[spawnerIndex].rotation);
            NuevoItem();

        }
    }
}
