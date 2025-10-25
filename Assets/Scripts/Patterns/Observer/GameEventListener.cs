using Patterns.Observer.Patterns.Observer;
using UnityEngine;
using UnityEngine.Assertions;

namespace Patterns.Observer
{
    public class GameEventListener<T> : MonoBehaviour
    {
        [SerializeField] private GameEvent<T> m_Event;
        [SerializeField] private GameEventResponse<T> m_EventResponse = new GameEventResponse<T>();

        private void Awake()
        {
            Assert.IsNotNull(m_Event, $"{nameof(GameEventListener<T>)} has no {nameof(GameEvent<T>)} assigned");
        }

        private void OnEnable()
        {
            m_Event?.Register(this);
        }

        private void OnDisable()
        {
            m_Event?.Unregister(this);
        }

        public void OnEventOccurs(T value)
        {
            m_EventResponse?.Invoke(value);
        }
    }
}