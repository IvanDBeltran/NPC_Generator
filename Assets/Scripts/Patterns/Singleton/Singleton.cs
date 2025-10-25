using UnityEngine;

namespace Patterns.Singleton
{
    [DefaultExecutionOrder(-100)]
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T m_Instance;
        private static readonly object m_Lock = new object();

        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (m_Lock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = FindFirstObjectByType<T>();
                            if (m_Instance == null)
                            {
                                GameObject obj = new GameObject(typeof(T).Name);
                                m_Instance = obj.AddComponent<T>();
                            }
                        }
                    }
                }
                return m_Instance;
            }
        }

        public static bool IsInitialized => m_Instance != null;

        public virtual void Awake()
        {
            if (m_Instance == null)
            {
                m_Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else if (m_Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}

