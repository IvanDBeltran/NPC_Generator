using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

namespace Patterns.Observer
{
    [System.Serializable]
    public class VoidEventListener : MonoBehaviour
    {
        [SerializeField] private VoidEvent m_VoidEvent;
        [SerializeField] private UnityEvent m_VoidEventRaised;
        
        private void Awake()
        {
            if (!m_VoidEvent)
            {
                Assert.IsNotNull(m_VoidEvent, $"{nameof(VoidEventListener)} has no {nameof(VoidEvent)} assigned");
            }
        }
        private void OnEnable()
        {
            m_VoidEvent.Register(this);
        }

        private void OnDisable()
        {
            m_VoidEvent.Unregister(this);
        }
        public void OnEventOccurs()
        {
            m_VoidEventRaised?.Invoke();
        }
    }
}