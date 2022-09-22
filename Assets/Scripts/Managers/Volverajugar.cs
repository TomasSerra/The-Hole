using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volverajugar : MonoBehaviour {


    void OnMouseDown()
    {
        SceneManager.LoadScene("Juego");
    }
}
