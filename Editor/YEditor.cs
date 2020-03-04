using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YEditor
{

    public struct ButtonData
    {

        public Rect Position;
        public string Label;

        public ButtonData(Rect rect, string label)
        {

            Position = rect;
            Label = label;

        }

    }

    public class YEditor : MonoBehaviour
    {

    }

}
