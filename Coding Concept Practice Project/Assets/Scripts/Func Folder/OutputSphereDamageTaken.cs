using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSphereDamageTaken : MonoBehaviour
{
    private void OnEnable()
    {
        SphereFuncDisable.OnSphereDisable += OutputDamageTaken;
    }

    private string OutputDamageTaken(int damage)
    {
        var damageTaken = $"WHOOAA! {damage} Damage Taken!";
        return damageTaken;
    }
}
