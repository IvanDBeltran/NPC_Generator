using UnityEditor;

namespace Patterns.Observer.Editor
{
    [CustomEditor(typeof(IntEvent))]
    public class IntEventEditor : GameEventEditor<int>
    {
        protected override int DrawValueField(int value)
        {
            return EditorGUILayout.IntField("Test Value", value);
        }
    }
}