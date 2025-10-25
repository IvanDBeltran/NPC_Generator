using UnityEngine;

namespace Patterns.Observer
{
    [CreateAssetMenu(fileName = "IntEvent", menuName = "ScriptableObjects/IntEvent", order = 3)]
    public class IntEvent : GameEvent<int> {}
}