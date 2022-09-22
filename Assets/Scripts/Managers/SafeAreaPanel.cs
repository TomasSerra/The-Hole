using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public delegate void Cambio(Rect safeArea);
    public static event Cambio OnCambio;

    private Rect _safeArea;

    void Awake()
    {
        _safeArea = Screen.safeArea;
    }

    void Update()
    {
        if(_safeArea != Screen.safeArea)
        {
            _safeArea = Screen.safeArea;
            OnCambio?.Invoke(_safeArea);
        }
    }
}
