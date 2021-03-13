using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public float[] sumValues;
    public bool[] boolInputs;
    public string[] textSegments;
    public GameObject[] objects;

    public float CalculateSum()
    {
        float sum = 0;

        foreach (var value in sumValues)
        {
            sum += value;
        }

        return sum;
    }

    public bool CalculateOuput()
    {
        int numTrue = 0;
        int numFalse = 0;

        foreach(var input in boolInputs)
        {
            if (input)
            {
                numTrue++;
            }
            else
            {
                numFalse++;
            }
        }

        if(numFalse > numTrue)
        {
            return false;
        }

        return true;
    }

    public string CreateText()
    {
        string text = null;

        foreach(var segment in textSegments)
        {
            text += segment;
        }

        return text;
    }

    public float AverageYPosition()
    {
        float ySum = 0;

        foreach(var entity in objects)
        {
            ySum += entity.transform.position.y;
        }

        return ySum / objects.Length;
    }
}
