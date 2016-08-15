using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(FractalTree))]
public class TreeGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        FractalTree tree = (FractalTree)target;

        // If inspector is changed
        if(DrawDefaultInspector())
        {
            tree.GenerateTree();
        }

        if (GUILayout.Button("Generate Tree"))
        {
            tree.GenerateTree();
        }
    }
}
