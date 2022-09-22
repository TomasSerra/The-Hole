using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarSliders : MonoBehaviour {

    public GameObject slideRealentizar;
    public GameObject sliderAgrandarVision;
    public GameObject sliderEscudo;

    public void SliderRealentizar()
    {
        slideRealentizar.SetActive(true);
    }

    public void SliderAgrandarVision()
    {
        sliderAgrandarVision.SetActive(true);
    }

    public void SliderEscudo()
    {
        sliderEscudo.SetActive(true);
    }
}
