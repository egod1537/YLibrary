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

        public static void OnAnimationStart(this Animator animator, UnityAction<AnimatorStateInfo> callback)
        {

            IEnumerator Coroutin()
            {

                AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);

                while (
                    ((info = animator.GetCurrentAnimatorStateInfo(0)).normalizedTime % 1) < 0.1f)
                {

                    yield return null;

                }

                callback(info);

            }

            YCoroutin.instance.StartCoroutine(Coroutin());

        }
        public static void OnAnimationEnd(this Animator animator, UnityAction<AnimatorStateInfo> callback)
        {

            IEnumerator Coroutin()
            {

                AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);

                while (
                    ((info = animator.GetCurrentAnimatorStateInfo(0)).normalizedTime % 1) < 0.9f)
                {

                    yield return null;

                }

                callback(info);

            }

            YCoroutin.instance.StartCoroutine(Coroutin());

        }

    }

}
