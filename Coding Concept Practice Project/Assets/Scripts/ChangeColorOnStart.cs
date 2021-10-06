using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnStart : MonoBehaviour
{
    delegate void ChangeColor(Color color);

    private ChangeColor _changeColor;
    void Start()
    {
        _changeColor += Swap;
        
        _changeColor(Color.cyan);

        _changeColor -= Swap;
        
        _changeColor += PassANewColor;
        
        _changeColor(Color.red);

        _changeColor -= PassANewColor;
    }

    private void Swap(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    private void PassANewColor(Color color)
    {
        Debug.Log("The new color is " + color);
    }
}
