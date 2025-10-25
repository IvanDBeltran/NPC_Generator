using UnityEditor;
using UnityEngine;

namespace Patterns.Observer.Editor
{
    public abstract class GameEventEditor<T> : UnityEditor.Editor
    {
        private T m_TestValue;
        private readonly float m_Width = 10f;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            EditorGUILayout.Space(m_Width);
            EditorGUILayout.LabelField("Debug Tools", EditorStyles.boldLabel);

            m_TestValue = DrawValueField(m_TestValue);

            if (GUILayout.Button("Raise Event"))
            {
                RaiseTestEvent();
            }
        }

        protected abstract T DrawValueField(T value);

        private void RaiseTestEvent()
        {
            var gameEvent = (GameEvent<T>)target;
            gameEvent.Occurred(m_TestValue);
            Debug.Log($"Raised {typeof(T).Name} Event with value: {m_TestValue}");
        }
    }
}


