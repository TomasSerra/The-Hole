using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgrandarVisionItem : MonoBehaviour {

    PerseguirMouse spriteMask;
    ActivarSliders activarSlider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            spriteMask = GameObject.FindGameObjectWithTag("Mask").GetComponent<PerseguirMouse>();
            activarSlider = GameObject.FindGameObjectWithTag("Manager").GetComponent<ActivarSliders>();
            spriteMask.Agrandar();
            activarSlider.SliderAgrandarVision();
            Destroy(this.gameObject);
        }

    }

   
}
