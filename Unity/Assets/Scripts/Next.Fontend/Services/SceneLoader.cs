using UnityEngine.SceneManagement;

namespace Next.Fontend
{
    public interface ISceneLoader 
    {
        void LoadScene(string sceneName, System.Action onLoaded = null);
    }
    
    public class SceneLoader : ISceneLoader
    {
        public void LoadScene(string nextScene, System.Action onLoaded = null)
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.LoadScene(nextScene);

            void OnSceneLoaded(Scene s, LoadSceneMode m)
            {
                SceneManager.sceneLoaded -= OnSceneLoaded;
                onLoaded?.Invoke();
            }
        }
    }
}