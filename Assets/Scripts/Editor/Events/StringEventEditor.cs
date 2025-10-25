using UnityEditor;

namespace Patterns.Observer.Editor
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : GameEventEditor<string>
    {
        protected override string DrawValueField(string value)
        {
            return EditorGUILayout.TextField("Test Value", value);
        }
    }
}