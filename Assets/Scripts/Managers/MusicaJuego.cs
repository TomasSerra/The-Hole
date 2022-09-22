using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaJuego : MonoBehaviour
{
    void Awake()
    {
            Destroy(GameObject.FindGameObjectWithTag("Musica"));
    }
}
