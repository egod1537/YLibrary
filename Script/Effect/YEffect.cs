using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YLibrary
{

    public class YEffect : YScript
    {

        public string basePath = "Effect/";

        public Dictionary<string, GameObject> Pool;

        private void Awake()
        {

            Pool = new Dictionary<string, GameObject>();

            SubscribeOnDestory(OnDestroy);

        }

        private void OnDestroy()
        {

            Pool.Clear();

        }

        public GameObject GetEffect(string path)
        {

            if (Pool.ContainsKey(path)) Pool[path] = Resources.Load(basePath + path) as GameObject;

            return Pool[path];

        }

        public GameObject RunEffect(string path, float duration = 1f, Vector3 position = new Vector3())
        {

            GameObject go = Instantiate(GetEffect(path));

            go.transform.position = position;

            go.AddComponent<YEffectTimer>().duration = duration;

            return go;

        }

    }

}
