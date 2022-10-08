using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitwiseComplement : MonoBehaviour
{
    // Start is called before the first frame update
    private uint a;
    private uint b;

    void Start()
    {
        a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
        b = ~a;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Convert.ToString(b, toBase: 2));
    // Output:
   // 11110000111100001111000011110011
    }
}