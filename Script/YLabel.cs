using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace YLibrary
{

    public class YLabel<T> : MonoBehaviour
    {

        protected TextMeshProUGUI tr_Text;

        T cash = default(T);

        private void Awake()
        {

            tr_Text = GetComponent<TextMeshProUGUI>();

        }

        public void SetText(T value)
        {

            if (value.Equals(cash)) return;

            cash = value;

            tr_Text.text = cash.ToString();

        }

    }

}
