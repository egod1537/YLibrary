using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YLibrary
{

    public class ObjectPool : YSingleton<ObjectPool>
    {

        private static Dictionary<string, Transform> Pools = new Dictionary<string, Transform>();
        private static Dictionary<string, GameObject> Dummy = new Dictionary<string, GameObject>();

        public static void CreatePool(string name, GameObject go)
        {

            if (!Pools.ContainsKey(name))
            {

                Transform tr = new GameObject().transform;
                tr.SetParent(instance.transform);
                Pools.Add(name, tr.transform);

                tr.name = name;

            }

            if(!Dummy.ContainsKey(name)) Dummy.Add(name, go);

        }

        public static void InPool(string name, GameObject go)
        {

            go.SetActive(false);

            go.transform.SetParent(Pools[name], false);

        }

        public static GameObject OutPool(string name)
        {

            Transform pool = Pools[name];

            if (pool.childCount == 0)
            {

                GameObject go = Instantiate(Dummy[name]);

                go.name = name;

                go.transform.SetParent(pool, false);

            }

            GameObject result = pool.GetChild(0).gameObject;

            result.SetActive(true);

            return result;

        }

        private void OnDestroy()
        {

            Pools.Clear();
            Dummy.Clear();

        }

    }


}