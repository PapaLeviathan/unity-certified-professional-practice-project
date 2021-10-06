using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnStart : MonoBehaviour
{
    public delegate void ChangeColor(Color color);

    public ChangeColor _changeColor;
    
    void Awake()
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
        Debug.Log("The new color not applied to the sphere is " + color);
    }
}
