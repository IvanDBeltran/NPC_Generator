using System;
using UnityEngine.Events;

namespace Patterns.Observer
{
    [Serializable]
    public class OnStringEvent : UnityEvent<string>{}
}