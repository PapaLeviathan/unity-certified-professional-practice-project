using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    void DestroyMyCube(float delay)
    {
        Debug.Log("Calling cube method");
        Destroy(gameObject, delay);
    }
}