using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryToUseDelegateFromAnotherScript : MonoBehaviour
{
    private ChangeColorOnStart _changeColorScript;
    void Start()
    {
        _changeColorScript = GetComponent<ChangeColorOnStart>();

        _changeColorScript._changeColor += ChangeColorFromAnotherScript;
        
        _changeColorScript._changeColor(Color.green);
    }

    private void ChangeColorFromAnotherScript(Color color)
    {
        Debug.Log("This color, " + color +", is from another script.");
    }
}
