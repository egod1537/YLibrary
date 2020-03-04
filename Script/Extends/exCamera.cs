using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exCamera
    {

        public static void Shake(this Camera camera, float duration, float vibration = 1f)
        {

            bool end = false;

            IEnumerator delay()
            {

                yield return new WaitForSeconds(duration);

                end = true;

            }

            IEnumerator method()
            {

                YCoroutin.instance.StartCoroutine(delay());

                Transform tr_camera = camera.gameObject.transform;

                Vector3 initPos = tr_camera.position;

                while (!end)
                {

                    tr_camera.position
                         = Random.onUnitSphere * vibration + initPos;

                    yield return new WaitForEndOfFrame();

                }

                tr_camera.position = initPos;

            }

            YCoroutin.instance.StartCoroutine(method());

        }

    }

}
