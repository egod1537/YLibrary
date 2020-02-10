using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public class SSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {

        protected static T instance = null;

        public static void Init()
        {

            GameObject go = new GameObject();
            go.name = typeof(T).Name;
            instance = go.AddComponent<T>();

        }

    }

}
