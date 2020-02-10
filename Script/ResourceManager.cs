using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public class ResourceManager : YSingleton<ResourceManager>
    {

        private static Dictionary<string, object> obj_db = new Dictionary<string, object>();

        public static object Load(string path)
        {

            if (!obj_db.ContainsKey(path))
                obj_db.Add(path, Resources.Load(path));

            return obj_db[path];

        }

        private void OnDestroy()
        {

            obj_db.Clear();

        }

    }

}
