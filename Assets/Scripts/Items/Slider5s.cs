using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider5s : MonoBehaviour {

    float contadorTiempo;
    Slider slider;
    public float valorInicial;

	void Start () {
        slider = GetComponent<Slider>();
        contadorTiempo = valorInicial;
	}
	
	
	void Update () {

        contadorTiempo = contadorTiempo - Time.deltaTime;
        slider.value = contadorTiempo;
        if(contadorTiempo <= 0f)
        {
            slider.value = valorInicial;
            contadorTiempo = valorInicial;
            this.gameObject.SetActive(false);
        }

    }
}
