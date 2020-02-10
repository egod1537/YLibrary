using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public class YLibrary : MonoBehaviour
    {

        private void Awake()
        {

            Init();

        }

        public static void Init()
        {

            YScene.Init();

            YCSVLoader.Init();

        }

    }

}
