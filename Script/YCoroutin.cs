using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YLibrary
{

    public class YCoroutin : YSingleton<YCoroutin>
    {

        public delegate IEnumerator Method();

        public void DelayMethod(float delay, UnityAction callback)
        {

            IEnumerator _Coroutin()
            {

                yield return new WaitForSeconds(delay);

                callback();

            }

            RunCoroutin(_Coroutin());

        }

        public void RunCoroutin(IEnumerator callback)
        {
            StartCoroutine(callback);
        }

        public IEnumerator MainCoroutin(Method callback)
        {
            yield return callback;
        }

    }

}
