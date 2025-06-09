using System.Linq;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;

namespace Narazaka.Unity.MeshCombineStudioOnBuild.Editor
{
    public class MeshCombineStudioOnBuildProcessor : IProcessSceneWithReport
    {
        public int callbackOrder => -2048;

        public void OnProcessScene(Scene scene, BuildReport report)
        {
            var meshCombiners = SceneManager.GetActiveScene().GetRootGameObjects().SelectMany(go => go.GetComponentsInChildren<MeshCombineStudioOnBuild>()).SelectMany(m => m.meshCombiners).Distinct().ToArray();
            foreach (var meshCombiner in meshCombiners)
            {
                meshCombiner.CombineAll();
            }
        }
    }
}
