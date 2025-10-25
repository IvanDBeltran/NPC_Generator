using UnityEditor;
using UnityEngine;

namespace Patterns.Observer.Editor
{
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Debug Tools", EditorStyles.boldLabel);

            if (GUILayout.Button("Raise Event"))
            {
                var gameEvent = (VoidEvent)target;
                gameEvent.Occurred();
                Debug.Log("Raised Void Event");
            }
        }
    }
}