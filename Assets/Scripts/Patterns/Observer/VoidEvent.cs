using System;
using System.Collections.Generic;
using UnityEngine;

namespace  Patterns.Observer
{
    [CreateAssetMenu(fileName = "VoidEvent", menuName = "ScriptableObjects/VoidEvent", order = 1)]
    public class VoidEvent : ScriptableObject
    {
        private List<VoidEventListener> m_Listeners = new List<VoidEventListener>();

        public void Register(VoidEventListener listener)
        {
            m_Listeners?.Add(listener);
        }

        public void Unregister(VoidEventListener listener)
        {
            m_Listeners?.Remove(listener);
        }

        public void Occurred()
        {
            for (int i = 0; i < m_Listeners.Count; i++)
            {
                m_Listeners[i].OnEventOccurs();
            }
        }
    }
}

