using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YLibrary;
using UnityEditor;

namespace YEditor
{

    using ActionType = YActionBehaviour.ActionType;

    [CustomEditor(typeof(YAction))]
    [CanEditMultipleObjects]
    public class Editor_YAction : Editor
    {

        static YAction script;

        class AEditor
        {

            public virtual void Execute(int num) { }

        }

        class EditorActiveObject : AEditor
        {

            public override void Execute(int num)
            {

                GUILayout.BeginVertical("HelpBox");

                    GUIStyle style = new GUIStyle();

                    style.alignment = TextAnchor.MiddleCenter;

                    EditorGUILayout.LabelField("Active Object Property", style);

                    script.Actions[num].size = EditorGUILayout.IntField("size", script.Actions[num].size);

                    int size = script.Actions[num].size;

                    if (script.Actions[num].Objects == null || size != script.Actions[num].Objects.Length)
                    {

                        script.Actions[num].Objects = new GameObject[size];
                        script.Actions[num].ObjectActives = new bool[size];

                    }

                for (int i = 0; i < size; i++)
                {

                    EditorGUILayout.BeginHorizontal();

                    script.Actions[num].ObjectActives[i] = EditorGUILayout.Toggle(script.Actions[num].ObjectActives[i]);

                    script.Actions[num].Objects[i] =
                            (GameObject)EditorGUILayout.ObjectField("Gameobject", script.Actions[num].Objects[i], typeof(GameObject), true);

                    EditorGUILayout.EndHorizontal();

                }

                GUILayout.EndVertical();

            }

        }

        class EditorNextScene : AEditor
        {

            public override void Execute(int num)
            {

                GUILayout.BeginVertical("HelpBox");

                    GUIStyle style = new GUIStyle();

                    style.alignment = TextAnchor.MiddleCenter;

                    EditorGUILayout.LabelField("Next Scene Property", style);

                script.Actions[num].SceneName = EditorGUILayout.TextField("Scene Name", script.Actions[num].SceneName);

                GUILayout.EndVertical();

            }

        }

        class EditorFunction : AEditor
        {

            public override void Execute(int num)
            {

                GUILayout.BeginVertical("HelpBox");

                    GUIStyle style = new GUIStyle();

                    style.alignment = TextAnchor.MiddleCenter;

                    EditorGUILayout.LabelField("Function Property", style);

                    SerializedObject so = new SerializedObject(script);

                    SerializedProperty sp = so.FindProperty("Actions");

                    sp = sp.GetArrayElementAtIndex(num);

                    sp = sp.FindPropertyRelative("OnFunction");

                    EditorGUILayout.PropertyField(sp);

                    so.ApplyModifiedProperties();

                GUILayout.EndVertical();

            }

        }

        Dictionary<ActionType, AEditor> GUIs = new Dictionary<ActionType, AEditor>();

        private void OnEnable()
        {

            GUIs.Add(ActionType.ACTIVE_OBJECT, new EditorActiveObject());
            GUIs.Add(ActionType.NEXT_SCENE, new EditorNextScene());
            GUIs.Add(ActionType.FUNTION, new EditorFunction());

            script = (YAction)target;

        }

        public override void OnInspectorGUI()
        {

            script.size = EditorGUILayout.IntField("Size", script.size);

            InitializeArray();

            for (int i=0; i < script.size; i++)
            {

                GUILayout.BeginVertical("GroupBox");

                    script.Actions[i].key = EditorGUILayout.TextField("Action Name", script.Actions[i].key);

                    script.Actions[i].Type =
                        (ActionType)EditorGUILayout.EnumFlagsField("Action Type", script.Actions[i].Type);

                    GUIProeperty(i, script.Actions[i].Type);

                GUILayout.EndVertical();

            }

        }

        public void InitializeArray()
        {

            if (script.ActionName == null || script.ActionName.Length != script.size)
                script.ActionName = new string[script.size];

            if (script.Actions == null || script.Actions.Length != script.size)
                script.Actions = new YActionBehaviour[script.size];

        }

        public void GUIProeperty(int num, ActionType Type)
        {

            int count = (int)ActionType.COUNT;

            for (int j = 0; j < count; j++)
            {

                ActionType type = (ActionType)(1 << j);

                if (Type.HasFlag(type))
                    GUIs[type].Execute(num);

            }

        }

    }

}
