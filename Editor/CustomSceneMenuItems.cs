using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using SceneUtility = WinuXGames.SplitFramework.Utility.SceneUtility;
using EditorUtility = WinuXGames.SplitFramework.Utility.Editor.EditorUtility;


namespace WinuXGames.SplitFramework.Core.Editor
{
    public static class CustomSceneMenuItems
    {
        private static readonly List<Scene>  PreviousScenes     = new List<Scene>();
        private static readonly List<string> PreviousScenePaths = new List<string>();
        
        [MenuItem("Custom/Scene/Load Current With Base")]
        private static void LoadCurrentWithBase() { LoadCurrentWithBaseScene(); }

        private static void LoadScenesEditor(IReadOnlyList<string> scenePaths, bool unloadOpen = true)
        {
            for (int i = 0; i < scenePaths.Count; i++)
            {
                string previousScene = scenePaths[i];
                EditorSceneManager.OpenScene(previousScene, i == 0 && unloadOpen ? OpenSceneMode.Single : OpenSceneMode.Additive);
            }
        }

        private static void LoadCurrentWithBaseScene()
        {
            if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) { return; }

            PreviousScenePaths.Clear();
            SceneUtility.GetCurrentlyLoadedScenesNonAlloc(PreviousScenes);
            PreviousScenePaths.AddRange(PreviousScenes.Select(x => x.path));
            
            EditorSceneManager.OpenScene(EditorUtility.BaseScenePath, OpenSceneMode.Single);
            
            LoadScenesEditor(PreviousScenePaths, false);
        }
    }
}