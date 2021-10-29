using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MyMonoBehaviourTest : MonoBehaviour, IMonoBehaviourTest
{
    private int _frameCount;
    public bool IsTestFinished
    {
        get { return _frameCount > 10; }
    }


    [UnityTest]
    public IEnumerator MonoBehaviourTest_works()

    {
        yield return new MonoBehaviourTest<MyMonoBehaviourTest>();
    }
}