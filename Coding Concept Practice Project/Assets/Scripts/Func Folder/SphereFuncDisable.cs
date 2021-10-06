using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFuncDisable : MonoBehaviour
{
    public static Func<int, string> OnSphereDisable;
    private int _sphereDamageTaken = 1000;

    private void OnDisable()
    {
        Debug.Log(OnSphereDisable?.Invoke(_sphereDamageTaken));
    }
}
