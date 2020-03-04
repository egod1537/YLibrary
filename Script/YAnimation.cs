using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using System;
using UnityEngine.UI;

namespace YLibrary
{

    public class YAnimation : MonoBehaviour
    {

        public UnityAction OnAnimationStart = () => { };
        public UnityAction OnAnimationEnd = () => { };   
        
        [Serializable]
        public struct KeyFrame
        {

            public float delay, duration;

            public Vector3 Position, Rotation, Scale;

            public Ease Ease;

            public Color Color;

        }

        [Flags]
        public enum AnimationType
        {

            CALL = 1 << 0,
            AWAKE = 1 << 1,
            START = 1 << 2,
            COUNT = 3

        }

        public AnimationType Type;

        public int size;
        public KeyFrame[] KeyFrames;

        Sequence seq;

        Image trImage;

        private void Awake()
        {

            seq = DOTween.Sequence();

            seq.SetAutoKill(false);

            trImage = GetComponent<Image>();

            float time = 0f;

            for(int i=0; i < size; i++)
            {

                KeyFrame frame = KeyFrames[i];

                time += frame.delay;

                seq.Insert(time,
                    transform.DOLocalMove(frame.Position, frame.duration)
                    .SetEase(frame.Ease));

                seq.Insert(time,
                    transform.DOLocalRotate(frame.Rotation, frame.duration)
                    .SetEase(frame.Ease));

                seq.Insert(time,
                    transform.DOScale(frame.Scale, frame.duration)
                    .SetEase(frame.Ease));

                if (trImage != null)
                    seq.Insert(time,
                        trImage.DOColor(frame.Color, frame.duration)
                        .SetEase(frame.Ease));

                time += frame.duration;

            }

        }

        public void FowardPlay()
        {

            OnAnimationStart();

            seq.OnComplete(
                () => { OnAnimationEnd(); });

            seq.Restart();

        }

        public void BackwardPlay()
        {

            OnAnimationStart();

            seq.OnRewind(() => { OnAnimationEnd(); });

            seq.PlayBackwards();

        }

    }

}
