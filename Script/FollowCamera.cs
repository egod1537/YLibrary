using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace YLibrary
{

    public class FollowCamera : MonoBehaviour
    {

        public Transform Target;
        public float delay;
        public Ease Ease;

        private void Update()
        {

            if (Target == null) return;

            transform.DOMoveX(Target.position.x, delay)
                .SetEase(Ease);
            transform.DOMoveY(Target.position.y, delay)
                .SetEase(Ease);

        }

    }

}
