using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour {

    /*[HideInInspector]*/ public float horizontal;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
}
