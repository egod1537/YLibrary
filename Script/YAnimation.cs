using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using System;

namespace YLibrary
{

    public class YAnimation : MonoBehaviour
    {

        public class Animation : UnityEvent { }
        public class AnimationStart : UnityEvent { }
        public class AnimationEnd : UnityEvent { }

        private Dictionary<string, Animation> Animations;
        private Dictionary<string, AnimationStart> OnAnimationStart;
        private Dictionary<string, AnimationEnd> OnAnimationEnd;

        public virtual void Awake()
        {

            Animations = new Dictionary<string, Animation>();
            OnAnimationEnd = new Dictionary<string, AnimationEnd>();

        }

        private void OnDestroy()
        {

            Animations.Clear();

        }

        public void AddAnimation(string animation_name, UnityAction animation) {

            if (!Animations.ContainsKey(animation_name))
                Animations.Add(animation_name, new Animation());

            Animations[animation_name].AddListener(animation);

        }

        public void AddAnimationEndCallback(string animation_name, UnityAction callback)
        {
            OnAnimationEnd[animation_name].AddListener(callback);
        }

        public void InvokeAnimationEndCallback(string animation_name) => OnAnimationEnd[animation_name].Invoke();

        public void PlayAnimation(string animation_name)
        {

            if (!Animations.ContainsKey(animation_name)) return;

            Animations[animation_name].Invoke();

        }

    }

}