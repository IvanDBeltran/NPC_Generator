using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class GameEvent<T> : ScriptableObject
    {
        private readonly List<GameEventListener<T>> m_Listeners = new List<GameEventListener<T>>();

        public void Register(GameEventListener<T> listener)
        {
            if (!m_Listeners.Contains(listener))
                m_Listeners.Add(listener);
        }

        public void Unregister(GameEventListener<T> listener)
        {
            if (m_Listeners.Contains(listener))
                m_Listeners.Remove(listener);
        }

        public void Occurred(T value)
        {
            for (int i = 0; i < m_Listeners.Count; i++)
            {
                m_Listeners[i]?.OnEventOccurs(value);
            }
        }
    }
}