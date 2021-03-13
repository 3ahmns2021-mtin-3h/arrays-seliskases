using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Arrays))]
public class ArrayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Arrays arrays = (Arrays)target;
        EditorGUILayout.Space();


        if (GUILayout.Button("Calculate Sum"))
        {
            Debug.Log(arrays.CalculateSum());
        }
        EditorGUILayout.Space();

        if (GUILayout.Button("Calculate Output"))
        {
            Debug.Log(arrays.CalculateOuput());
        }
        EditorGUILayout.Space();

        if (GUILayout.Button("Create Text"))
        {
            Debug.Log(arrays.CreateText());
        }
        EditorGUILayout.Space();

        if (GUILayout.Button("Average Y-Position"))
        {
            Debug.Log(arrays.AverageYPosition());
        }
        EditorGUILayout.Space();
    }

}
