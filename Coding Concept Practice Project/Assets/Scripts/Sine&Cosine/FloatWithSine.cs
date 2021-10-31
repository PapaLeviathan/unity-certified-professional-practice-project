using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatWithSine : MonoBehaviour
{
    [SerializeField] private int _amplitude = 1;
    [SerializeField] private float _frequency = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time * _frequency) * _amplitude;
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}