using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grepid.Random;
using System.Globalization;

public class RandomTester : MonoBehaviour
{
    public int X;
    [NonReorderable]public TestingClass[] weightClasses;
    private float[] weightFloats => Weighted.ToWeights(weightClasses, "weight");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("ToWeights")]
    private void ToWeights()
    {
        foreach(float f in Weighted.ToWeights(weightClasses, "weight"))
        {
            print(f);
        }
    }
    [ContextMenu("InvertedWeights")]
    private void InvertedWeights()
    {
        /*foreach (float f in Weighted.InverseWeightWorth(weightFloats))
        {
            print(f);
        }*/
    }
    [ContextMenu("FlipWeights")]
    private void FlipWeights()
    {
        foreach(float f in Weighted.FlipValues(weightFloats))
        {
            print(f);
        }
    }
    [ContextMenu("InvertedWeights5")]
    private void InvertedWeights5()
    {
        /*foreach (float f in Weighted.InverseWeightWorth5(weightFloats))
        {
            print(f);
        }*/
    }
    [ContextMenu("XWeightTests")]
    private void XWeightTests()
    {
        foreach (TestingClass c in Weighted.RandomFromCollection(weightClasses,"weight",X,false))
        {
            print(c.name);
        }
    }

    [ContextMenu("XWeightTestsInverted")]
    private void XWeightTestsInverted()
    {
        /*foreach (int i in Weighted.RandomIndexes(Weighted.InverseWeightWorth(weightFloats), X, false))
        {
            print(weightClasses[i].name);
        }*/
        foreach (int i in Weighted.RandomIndexes(Weighted.FlipValues(weightFloats), X, false))
        {
            print(weightClasses[i].name);
        }
        
    }
    [ContextMenu("XWeightTestsInverted5")]
    private void XWeightTestsInverted5()
    {
        /*foreach (int i in Weighted.RandomIndexes(Weighted.InverseWeightWorth5(weightFloats), X, false))
        {
            print(weightClasses[i].name);
        }*/
    }
    [ContextMenu("XWeightTestsInvertedTest")]
    private void XWeightTestsInvertedTest()
    {
        foreach (int i in Weighted.RandomIndexesInverted(weightFloats, X, false))
        {
            print(weightClasses[i].name);
        }
    }
}
