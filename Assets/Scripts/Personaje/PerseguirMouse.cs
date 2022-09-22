using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerseguirMouse : MonoBehaviour {

    Transform miTransform;
    public GameObject agrandarVisionSlider;

    void Start () {
        miTransform = GetComponent<Transform>();
	}
	
	
	void Update () {
        miTransform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
	}

    public void Agrandar()
    {
        StartCoroutine(AgrandarVision());
    }

    public void AparecerSlider()
    {
        agrandarVisionSlider.SetActive(true);
    }

    IEnumerator AgrandarVision()
    {

        miTransform.localScale = new Vector3 (0.4f, 0.4f, 0 );
        yield return new WaitForSeconds(5);
        miTransform.localScale = new Vector3(0.27f, 0.27f, 0);
    }



}
