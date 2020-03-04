using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YLibrary
{

    [RequireComponent(typeof(Button))]
    public class YButton : MonoBehaviour
    , IPointerDownHandler, IPointerUpHandler
    {

        bool ishold = false;

        public void FixedUpdate() { if (ishold) OnButtonClickPressed(); }

        public virtual void OnButtonClickDown() { }

        public virtual void OnButtonClickPressed() { }

        public virtual void OnButtonClickUp() { }

        public void OnPointerDown(PointerEventData eventData)
        {

            ishold = true;
            OnButtonClickDown();

        }

        public void OnPointerUp(PointerEventData eventData)
        {

            ishold = false;
            OnButtonClickUp();

        }

    }

}
