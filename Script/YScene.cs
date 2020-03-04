using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YLibrary
{

    public class YScene : MonoBehaviour
    {

        public static void LoadScene(string name)
        {

            IEnumerator Coroutin()
            {

                AsyncOperation ao = SceneManager.LoadSceneAsync(name);

                yield return null;

            }

            YCoroutin.instance.StartCoroutine(Coroutin());

        }
        public static void LoadScene(string name, YAnimation animation)
        {

            Canvas canvas = CreateCanvas();

            IEnumerator Coroutin()
            {

                AsyncOperation ao = SceneManager.LoadSceneAsync(name);

                ao.allowSceneActivation = false;

                animation.OnAnimationEnd = (
                    () =>
                    {

                        ao.allowSceneActivation = true;

                        animation.OnAnimationEnd = (
                            () =>
                            {

                                Destroy(canvas.gameObject);

                            });

                        animation.BackwardPlay();

                    });

                animation.FowardPlay();

                yield return null;

            }

            animation.transform.SetParent(canvas.transform);

            YCoroutin.instance.StartCoroutine(Coroutin());

        }

        private static Canvas CreateCanvas()
        {

            GameObject go = new GameObject();

            go.name = "Canvas";

            go.transform.localScale = Vector3.one * 0.009262048f;

            DontDestroyOnLoad(go);

            Canvas canvas = go.AddComponent<Canvas>();

            canvas.worldCamera = Camera.main;

            go.transform.SetParent(null);

            return canvas;

        }

    }

}
