using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    [CreateAssetMenu(fileName = "StringEvent", menuName = "ScriptableObjects/StringEvent", order = 2)]
    public class StringEvent : GameEvent<string> { }
}