using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        // Automatically generate the map if any value was changed in the inspector on the MapGenerator
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
                mapGen.DrawMapInEditor();
        }

        if (GUILayout.Button("Generate"))
            mapGen.DrawMapInEditor();
    }
}
