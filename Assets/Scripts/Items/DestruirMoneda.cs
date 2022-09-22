using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMoneda : MonoBehaviour {


    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
