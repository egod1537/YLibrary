using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

namespace YEditor
{

    [CustomEditor(typeof(Transform))]
    public class Editor_Transform : Editor
    {

        public class ButtonEvent : UnityEvent<string> { }
        public ButtonEvent OnButton = new ButtonEvent();

        Transform script;

        private void OnEnable()
        {

            script = (Transform)target;

            OnButton.AddListener((string name) =>
            {

                switch (name)
                {

                    case "P":
                        script.position = Vector3.zero;
                        break;

                    case "R":
                        script.eulerAngles = Vector3.zero;
                        break;

                    case "S":
                        script.localScale = Vector3.one;
                        break;

                }

            });

        }

        ButtonData[] Buttons = {

            new ButtonData(new Rect(100, 5, 30, 18), "P"),
            new ButtonData(new Rect(100, 27.5f, 30, 18), "R"),
            new ButtonData(new Rect(100, 50, 30, 18), "S")

        };

        public override void OnInspectorGUI()
        {

            script.position = EditorGUILayout.Vector3Field("Position", script.position);
            script.eulerAngles = EditorGUILayout.Vector3Field("Rotation", script.eulerAngles);
            script.localScale = EditorGUILayout.Vector3Field("Scale", script.localScale);

            foreach(var btn in Buttons)
                if (GUI.Button(btn.Position, btn.Label)) OnButton.Invoke(btn.Label);

        }

    }

}