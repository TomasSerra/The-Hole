using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Agujero : MonoBehaviour
{

    public Animator animacion;

    public void Apretado()
    {
        StartCoroutine(EsperaCambioEscena());
        animacion.SetBool("Tocado", true);
    }

    IEnumerator EsperaCambioEscena()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("Juego");
    }
}
