using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

using YLibrary;

namespace YLibraryEditor
{

    [InitializeOnLoad]
    public static class Init
    {

        const string OBJECT_NAME = "[YLibrary]";

        static Init()
        {

            Initialize();

            EditorSceneManager.sceneOpened += SceneOpenedCallback;
            EditorSceneManager.sceneSaving += SceneSavingCallback;
            EditorSceneManager.newSceneCreated += NewSceneCreateCallback;

        }

        static void Initialize()
        {

            GameObject find = GameObject.Find(OBJECT_NAME);

            if (find != null) return;

            GameObject go = new GameObject();

            go.name = OBJECT_NAME;

            go.AddComponent<Library>();

        }

        static void NewSceneCreateCallback(Scene scene, NewSceneSetup setup, NewSceneMode mode)
        {

            Initialize();

        }

        static void SceneSavingCallback(Scene scene, string path)
        {

            Initialize();

        }

        static void SceneOpenedCallback(Scene scene, OpenSceneMode mode)
        {

            Initialize();

        }

    }

}
