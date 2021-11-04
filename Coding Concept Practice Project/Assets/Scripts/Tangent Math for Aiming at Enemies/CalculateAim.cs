using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class CalculateAim : MonoBehaviour
{
    //reference to the enemy
    [SerializeField] private Transform _enemy;

    void Update()
    {
        // calculate direction: destination - source
        Vector3 direction = _enemy.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.green);
        //calculate the angle using the inverse tangent method
        float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        Debug.Log("Angle: " + angle); 
        
        //define the rotation along a specific axis using the angle
        //Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.up);
        //slerp from current rotation to the new specific rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
        //or
        //take out current euler angles, and we just add our new angle to it
        transform.eulerAngles = Vector3.up * angle;
    }
}