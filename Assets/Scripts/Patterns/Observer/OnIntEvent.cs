using System;
using UnityEngine.Events;

namespace Patterns.Observer
{
    [Serializable]
    public class OnIntEvent : UnityEvent<int>{}
}