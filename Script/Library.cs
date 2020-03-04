using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    [RequireComponent(typeof(YSound))]
    [RequireComponent(typeof(YResource))]
    [RequireComponent(typeof(YCoroutin))]
    [RequireComponent(typeof(YObjectPool))]
    [RequireComponent(typeof(YScene))]
    public class Library : MonoBehaviour
    {

        public static GameObject inst;

        private void Awake()
        {

            DontDestroyOnLoad(this.gameObject);

            inst = this.gameObject;

        }

    }

}
