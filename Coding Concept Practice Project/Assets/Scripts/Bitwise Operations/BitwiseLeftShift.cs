using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitwiseLeftShift : MonoBehaviour
{
    private uint x;
    private uint y;

    // Start is called before the first frame update
    void Start()
    {
        x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
         y = x << 4;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Before: {Convert.ToString(x, toBase: 2)}");
        Debug.Log($"After:  {Convert.ToString(y, toBase: 2)}");
        // Output:
        // Before: 11001001000000000000000000010001
        // After:  10010000000000000000000100010000
    }
}
