using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using YLibrary;

namespace YLibrary
{

    public static class exAnimator
    {

        public static void FowardPlay(this Animator animator, string animation_name)
        {
            animator.SetFloat("speed", 1f);
            animator.Play(animation_name);
        }
        public static void BackwardPlay(this Animator animator, string animation_name)
        {
            animator.SetFloat("speed", -1f);
            animator.Play(animation_name);
        }

        public static void CallAnimationStart(this Animator animator, UnityAction callback)
        {

            YCoroutin.instance.RunCoroutin(
                CoroutinCallAnimationStart(animator, callback));

        }
        private static IEnumerator CoroutinCallAnimationStart(Animator animator, UnityAction callback)
        {

            while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= -1f)
            {

                Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                yield return null;

            }

            callback();

        }

        public static void CallAnimationEnd(this Animator animator, UnityAction callback)
        {

            YCoroutin.instance.RunCoroutin(
                CoroutinCallAnimationEnd(animator, callback));

        }
        private static IEnumerator CoroutinCallAnimationEnd(Animator animator, UnityAction callback)
        {

            while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
                yield return null;

            callback();

        }

    }

}
