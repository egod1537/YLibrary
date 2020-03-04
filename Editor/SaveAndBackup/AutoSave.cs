using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.Events;

namespace YLibrary
{

    [InitializeOnLoad]
    public class AutoSave
    {

        public const int SAVE_FREQUENCY = 10;

        static AutoSave()
        {

            EditorTime.OnSecond.AddListener(
                (int sec) =>
                {

                    if(EditorTime.second % SAVE_FREQUENCY == 0)
                    {

                        EditorApplication.SaveScene(
                            EditorApplication.currentScene);

                    }

                });

            EditorApplication.update += Update;

        }

        static void Update()
        {

        }

    }

}
