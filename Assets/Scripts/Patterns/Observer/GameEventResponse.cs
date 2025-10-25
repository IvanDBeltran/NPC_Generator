using System;
using UnityEngine.Events;

namespace Patterns.Observer.Patterns.Observer
{
    [Serializable]
    public class GameEventResponse<T> : UnityEvent<T> { }
}