using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

namespace YLibraryEditor
{

    public class CreateObject
    {

        [MenuItem("YLibrary/Create/Canvas #&_c")]
        private static void CreateCanvas()
        {

            #region CreateCanvas

            GameObject go;

            go = new GameObject("Canvas");

            go.AddComponent<RectTransform>();

            Canvas canvas = go.AddComponent<Canvas>();

            canvas.renderMode = RenderMode.ScreenSpaceCamera;

            canvas.worldCamera = Camera.main;

            CanvasScaler canvasScaler = go.AddComponent<CanvasScaler>();

            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

            canvasScaler.referenceResolution = new Vector2(1920f, 1080f);

            go.AddComponent<GraphicRaycaster>();

            #endregion

            #region Create EventSystem

            go = new GameObject("EventSystem");

            go.AddComponent<EventSystem>();

            go.AddComponent<StandaloneInputModule>();

            #endregion

        }

        [MenuItem("YLibrary/Create/Panel #&_p", false)]
        private static void CreatePanel(MenuCommand menuCommand)
        {

            GameObject go = new GameObject("Panel");

            GameObjectUtility.SetParentAndAlign(go, Selection.activeGameObject);

            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

        }

        [MenuItem("YLibrary/Create/Depth #&_d")]
        private static void CreateDepth()
        {

            Transform sel_tr = Selection.activeGameObject.transform;

            int child = sel_tr.childCount;

            int DepthCount = 0;

            for (int i = 0; i < child; i++)
                if (sel_tr.GetChild(i).name.Contains("Depth_"))
                     sel_tr.GetChild(i).name = "Depth_" + DepthCount++;
                    
            GameObject go = new GameObject("Depth_" + DepthCount.ToString());

            GameObjectUtility.SetParentAndAlign(go, Selection.activeGameObject);

            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

        }

        [MenuItem("YLibrary/Create/Sprite #&_s")]
        private static void CreateSprite()
        {

            GameObject go = new GameObject("Sprite");

            go.AddComponent<RectTransform>();
            go.AddComponent<CanvasRenderer>();
            go.AddComponent<Image>();

            GameObjectUtility.SetParentAndAlign(go, Selection.activeGameObject);

            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

        }

        [MenuItem("YLibrary/Create/Label #&_l")]
        private static void CreateLabel()
        {

            GameObject go = new GameObject("Label");

            go.AddComponent<RectTransform>();
            go.AddComponent<CanvasRenderer>();
            go.AddComponent<TextMeshProUGUI>();

            GameObjectUtility.SetParentAndAlign(go, Selection.activeGameObject);

            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

        }

        [MenuItem("YLibrary/Create/Button #&_b")]
        private static void CreateButton()
        {

            GameObject go = new GameObject("Button");

            go.AddComponent<RectTransform>();
            go.AddComponent<CanvasRenderer>();
            go.AddComponent<Image>();
            go.AddComponent<Button>();

            GameObjectUtility.SetParentAndAlign(go, Selection.activeGameObject);

            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);

        }

    }

}
