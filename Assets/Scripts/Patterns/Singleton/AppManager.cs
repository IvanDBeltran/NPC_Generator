using Patterns.Observer;
using UnityEngine.SceneManagement;

namespace Patterns.Singleton
{
    public class AppManager : Singleton<AppManager>
    {
        private void OnEnable()
        {
            SceneChangeBroadcaster.OnSceneChanged += ChangeScene;
        }

        private void ChangeScene(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
        }

        private void OnDisable()
        {
            SceneChangeBroadcaster.OnSceneChanged -= ChangeScene;
        }
    }
}