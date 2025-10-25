using Patterns.Singleton;
using UnityEngine;

namespace Patterns.Observer
{
    public class SceneChangeBroadcaster:MonoBehaviour
    {
        [SerializeField] private SCENES m_SceneNumber;
        
        public delegate void SceneChanged(int sceneNumber);
        public static event SceneChanged OnSceneChanged;
        
        public void NotifySceneChange()
        {
            OnSceneChanged?.Invoke((int)m_SceneNumber);
        }
    }
}