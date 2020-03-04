using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YLibrary
{

    public class YResource : YScript
    {

        private static Dictionary<string, object> obj_db = new Dictionary<string, object>();

        private void Awake()
        {

            SubscribeOnDestory(OnDestroy);

        }

        private void OnDestroy()
        {

            obj_db.Clear();

        }

        public static object Load(string path)
        {

            if (!obj_db.ContainsKey(path))
                obj_db.Add(path, Resources.Load(path));

            return obj_db[path];

        }

    }

}
