using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemEscudo : MonoBehaviour {

    Escudo escudo;

    ActivarSliders slider;

	void Start () {


	}
	
	
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            slider = GameObject.FindGameObjectWithTag("Manager").GetComponent<ActivarSliders>();
            slider.SliderEscudo();
            escudo = GameObject.FindGameObjectWithTag("Escudo").GetComponent<Escudo>();
            escudo.Activar();
        }
    }
}
