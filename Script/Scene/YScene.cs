using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

namespace YLibrary
{

    public class YScene : SSingleton<YScene>
    {

        private static string base_path = "YLibrary/";

        public class LoadStartScene : UnityEvent { }
        public static LoadStartScene OnLoadStartScene = new LoadStartScene();

        public class LoadingScene : UnityEvent<float> { }
        public static LoadingScene OnLoadingScene = new LoadingScene();

        public class LoadEndScene : UnityEvent { }
        public static LoadEndScene OnLoadEndScene = new LoadEndScene();

        private static Dictionary<string, GameObject> obj_db;

        private static Canvas tr_Canvas;

        private void Start()
        {

            DontDestroyOnLoad(instance);

            tr_Canvas = instance.gameObject.AddComponent<Canvas>();
            tr_Canvas.worldCamera = Camera.main;

            obj_db = new Dictionary<string, GameObject>();

        }

        private void OnDestroy()
        {

            OnLoadStartScene.RemoveAllListeners();
            OnLoadingScene.RemoveAllListeners();
            OnLoadEndScene.RemoveAllListeners();

            obj_db.Clear();

        }

        private static GameObject GetObject(string resource_path)
        {

            if (!obj_db.ContainsKey(resource_path))
            {

                obj_db.Add(
                    resource_path, Instantiate(Resources.Load(resource_path) as GameObject));

                obj_db[resource_path].name = resource_path;

                obj_db[resource_path].transform.SetParent(instance.transform);

            }

            return obj_db[resource_path];

        }

        public static void LoadScene(string scene_name, string resource_path = "Default", float time = 1)
        {

            resource_path = base_path + "YScene/" + resource_path;

            GameObject go = GetObject(resource_path);

            YAnimation animation = go.GetComponent<YAnimation>();

            OnLoadStartScene.AddListener(() =>{animation.PlayAnimation("FadeIn");});

            OnLoadEndScene.AddListener(() => {animation.PlayAnimation("FadeOut");});

            instance.StartCoroutine(
                CoroutainLoadScene(scene_name, time));

        }

        private static IEnumerator CoroutainLoadScene(string scene_name, float time)
        {

            OnLoadStartScene.Invoke();

            AsyncOperation ao = SceneManager.LoadSceneAsync(scene_name);

            ao.allowSceneActivation = false;

            while (ao.progress < 0.9f)
            {
                OnLoadingScene.Invoke(ao.progress);
                yield return null;
            }

            yield return new WaitForSeconds(time);

            ao.allowSceneActivation = true;

            OnLoadEndScene.Invoke();

        }

    }

}
