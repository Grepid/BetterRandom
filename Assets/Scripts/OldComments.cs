using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldComments
{
    #region Weights
    //I originally wrote the functions that can be told to iterate recursively. I don't know why, but I simplified them and decided to keep
    //their recursive selves as commented out methods because recursion is cool and it makes me feel fancy :3

    /*public static T[] RandomFromCollection<T>(ICollection<T> objects,string weightFieldName,int repetitions,bool noDupes)
    {
        List<T> modifiedObjects = new List<T>(objects);
        if (noDupes && repetitions > modifiedObjects.Count)
        {
            throw new ArgumentException("Cannot have more repetitions than objects whilst not allowing dupes.");
        }
        List<T> result = new List<T>();
        T rand = RandomFromCollection(modifiedObjects,weightFieldName);
        result.Add(rand);
        if(noDupes) modifiedObjects.Remove(rand);
        if (repetitions - 1 == 0) return result.ToArray();
        result.AddRange(RandomFromCollection(modifiedObjects, weightFieldName, repetitions - 1, noDupes));
        return result.ToArray();
    }*/

    //I originally wrote the functions that can be told to iterate recursively. I don't know why, but I simplified them and decided to keep
    //their recursive selves as commented out methods because recursion is cool and it makes me feel fancy :3

    /*public static int[] WeightedIndexes(ICollection<float> weights,int repetitions,bool noDupes)
    {
        List<float> modifiedWeights = new List<float>(weights);
        if (noDupes && repetitions > modifiedWeights.Count)
        {
            throw new ArgumentException("Cannot have more repetitions than objects whilst not allowing dupes.");
        }
        List<int> result = new List<int>();
        int rand = WeightedIndex(modifiedWeights);
        result.Add(rand);
        if(noDupes) modifiedWeights.RemoveAt(rand);
        if (repetitions - 1 == 0) return result.ToArray();
        result.AddRange(WeightedIndexes(modifiedWeights, repetitions - 1, noDupes));
        return result.ToArray();
    }*/

    // v Inverts based on lowest value and highest value
    /*public static float[] InverseWeightWorth2(ICollection<float> weights)
    {
        float[] result = weights.ToArray();
        float top = 0;
        float bottom = result[0];
        foreach(float f in result)
        {
            if(f < 0)
            {
                throw new ArgumentException("All weights should be positive. Use AbsWeights or ShiftWeightsToPositive if needed.");
            }
            if (f > top) top = f;
            if (f < bottom) bottom = f;
        }
        for(int i = 0; i < result.Length; i++)
        {
            float alpha = Mathf.Lerp(1, 0, result[i] / top);
            result[i] = Mathf.Lerp(bottom,top,alpha);
        }
        return result.ToArray();
    }*/


    /*public static float[] InverseWeightWorth3(ICollection<float> weights)
    {
        float[] result = weights.ToArray();
        //List<ValueTuple<float, int>> valuePlace = new();
        for (int i = 0; i<result.Length;i++)
        {

            if (result[i] < 0)
            {
                throw new ArgumentException("All weights should be positive. Use AbsWeights or ShiftWeightsToPositive if needed.");
            }

            //valuePlace.Add(new ValueTuple<float, int>(result[i], i));
        }

        float[] ordered = weights.OrderBy(x => x).ToArray();


        return result.ToArray();
    }*/

    /// <summary>
    /// 
    /// </summary>
    /// <param name="weights"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    /// 

    // v Inverts based on 0 to the total of all floats combined
    /*public static float[] InverseWeightWorth(ICollection<float> weights)
    {
        float[] result = weights.ToArray();
        float max = 0;
        foreach (float f in result)
        {
            if (f < 0)
            {
                throw new ArgumentException("All weights should be positive. Use AbsWeights or ShiftWeightsToPositive if needed.");
            }
            max += f;
        }
        for (int i = 0; i < result.Length; i++)
        {
            float alpha = Mathf.Lerp(1, 0, result[i] / max);
            result[i] = (float)Math.Round(Mathf.Lerp(0, max, alpha),4);
        }
        return result.ToArray();
    }
    public static float[] InverseWeightWorth5(ICollection<float> weights)
    {
        float[] result = weights.ToArray();
        float max = 0;
        foreach (float f in result)
        {
            if (f < 0)
            {
                throw new ArgumentException("All weights should be positive. Use AbsWeights or ShiftWeightsToPositive if needed.");
            }
            max += f;
        }
        for (int i = 0; i < result.Length; i++)
        {
            float alpha = Mathf.Lerp(1, 0, result[i] / max);
            result[i] = (float)Math.Round(Mathf.Lerp(0, max, alpha), 4);
        }
        float newTotal = 0;
        foreach(float f in result)
        {
            newTotal += f;
        }
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = (float)Math.Round(Mathf.Lerp(0, max, result[i]/newTotal), 4);
        }
        return result.ToArray();
    }*/
    #endregion
    #region Random
    #endregion
}
