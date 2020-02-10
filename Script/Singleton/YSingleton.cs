using UnityEngine;

namespace YLibrary
{

    public class YSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {

        private static T _instance;
        public static T instance
        {

            get
            {

                if (_instance == null)
                {

                    GameObject go = GameObject.Find(typeof(T).Name);

                    if (go == null)
                    {

                        go = new GameObject();
                        go.name = typeof(T).Name;
                        _instance = go.AddComponent<T>();

                    }
                    else
                        _instance = go.GetComponent<T>();

                }

                return _instance;

            }

        }

    }

}
