using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPersonaje : MonoBehaviour {

    public Sprite[] skins;

    SpriteRenderer sprites;

    private void Awake()
    {
        sprites = GetComponent<SpriteRenderer>();
    }


    void Start () {
	if (ElegirSkin() == 0)
        {
            sprites.sprite = skins[0];
        }
    else if (ElegirSkin() == 1)
        {
            sprites.sprite = skins[1];
        }
    else if (ElegirSkin() == 2)
        {
            sprites.sprite = skins[2];
        }
    else if (ElegirSkin() == 3)
        {
            sprites.sprite = skins[3];
        }
    else if (ElegirSkin() == 4)
        {
            sprites.sprite = skins[4];
        }
   else if (ElegirSkin() == 5)
        {
            sprites.sprite = skins[5];
        }
    }
	
	


    public int ElegirSkin ()
    {
        return PlayerPrefs.GetInt("SkinSeleccionado", 0);
    }
}
