using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Next.Fontend
{
    public interface ISceneService
    {
        UniTask LoadScene(string sceneName, LoadSceneMode loadSceneMode);
        UniTask UnloadSceneAsync(string sceneName);
    }
    
    public class SceneService : ISceneService
    {
        public async UniTask LoadScene(string sceneName, LoadSceneMode loadSceneMode)
        {
            await SceneManager.LoadSceneAsync(sceneName, loadSceneMode);
        }

        public async UniTask UnloadSceneAsync(string sceneName)
        {
            await SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}