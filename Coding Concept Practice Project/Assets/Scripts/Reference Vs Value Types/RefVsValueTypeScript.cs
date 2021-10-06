using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefVsValueTypeScript : MonoBehaviour
{
    void Start()
    {
        //reference type: Class
        MyClass _firstClass = new MyClass(10);
        
        //give another variable the value of _firstClass
        MyClass _secondClass = _firstClass;
        
        //change the value of the second variable. This will change the data set of the first variable since it is a reference to the first variable.
        _secondClass.value = 5;
        
        Debug.Log("First Class: " + _firstClass.value + ", which is to new (modified) value set for it by changing _secondClass.value.");
        
        //value type: Struct. This is its own set of information.
        MyStruct _firstStruct = new MyStruct(6);
        
        //This makes a set of information in _secondStruct that is equal to, but separate, from _firstStruct
        MyStruct _secondStruct = _firstStruct;

        //This changes the value of _secondStruct and ONLY _secondStruct because _secondStruct is its own set of information, created with "MyStruct _secondStruct"
        _secondStruct.value = 18;
        
        Debug.Log("First Struct: " + _firstStruct.value + ", which is the original (unchanged) value set for it even though _secondClass.value has been modified.");
    }

}

public class MyClass
{
    public int value;
    public MyClass(int value)
    {
        this.value = value;
    }
}

public struct MyStruct
{
    public int value;
    public MyStruct(int value)
    {
        this.value = value;
    }
}
