using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YLibrary;
using UnityEditor;
using DG.Tweening;
using UnityEngine.UI;

namespace YEditor
{

    using AnimationType = YAnimation.AnimationType;
    using KeyFrame = YAnimation.KeyFrame;

    [CustomEditor(typeof(YAnimation))]
    [CanEditMultipleObjects]
    public class Editor_YAnimation : Editor
    {

        YAnimation script;

        private void OnEnable()
        {

            script = (YAnimation)target;

        }

        public override void OnInspectorGUI()
        {
       
            script.Type = 
                (AnimationType) EditorGUILayout.EnumFlagsField("Move Type", script.Type);

            script.size = EditorGUILayout.IntField("size", script.size);

            if (script.KeyFrames == null || script.size != script.KeyFrames.Length)
                script.KeyFrames = new KeyFrame[script.size];

            for(int i=0; i < script.size; i++)
            {

                GUILayout.BeginVertical("GroupBox");

                    GUIStyle style = new GUIStyle();
                    style.alignment = TextAnchor.MiddleCenter;

                    EditorGUILayout.LabelField("Frame " + (i+1).ToString(), style);

                    script.KeyFrames[i].delay =
                        EditorGUILayout.FloatField("delay", script.KeyFrames[i].delay);

                    script.KeyFrames[i].duration =
                        EditorGUILayout.FloatField("duration", script.KeyFrames[i].duration);

                    script.KeyFrames[i].Ease =
                            (Ease) EditorGUILayout.EnumPopup("Ease", script.KeyFrames[i].Ease);

                    script.KeyFrames[i].Position = 
                        EditorGUILayout.Vector3Field("Position", script.KeyFrames[i].Position);

                    script.KeyFrames[i].Rotation =
                        EditorGUILayout.Vector3Field("Rotation", script.KeyFrames[i].Rotation);

                    script.KeyFrames[i].Scale =
                        EditorGUILayout.Vector3Field("Scale", script.KeyFrames[i].Scale);

                    if(GUILayout.Button("Set Transform"))
                    {

                        script.KeyFrames[i].Position = script.transform.localPosition;
                        script.KeyFrames[i].Rotation = script.transform.localEulerAngles;
                        script.KeyFrames[i].Scale = script.transform.localScale;

                    }

                    if (script.GetComponent<Image>() != null)
                            script.KeyFrames[i].Color =
                                EditorGUILayout.ColorField("Color", script.KeyFrames[i].Color);

                GUILayout.EndVertical();

            }

        }

    }

}
