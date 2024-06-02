using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grepid.Random;

public class RandomTester : MonoBehaviour
{
    [NonReorderable]public TestingClass[] weightClasses;
    private float[] weightFloats => Weighted.ToWeightList(weightClasses, "weight");
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
        foreach(float f in Weighted.ToWeightList(weightClasses, "weight"))
        {
            print(f);
        }
    }
    [ContextMenu("InvertedWeights")]
    private void InvertedWeights()
    {
        foreach (float f in Weighted.InverseWeightWorth(weightFloats))
        {
            print(f);
        }
    }
}
