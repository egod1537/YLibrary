using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YLibrary
{

    [Serializable]
    public class FunctionEvent : UnityEvent { }

    [Serializable]
    public class YActionBehaviour
    {

        class Property
        {

            #region ACTIVE_OBJECT Property

            public GameObject[] Objects;
            public bool[] ObjectActives;

            #endregion

            #region NEXT_SCENE Property

            public string SceneName;
            public YAnimation SceneAnimation;

            #endregion

            #region FUNCTION Property

            public FunctionEvent OnFunction = new FunctionEvent();

            #endregion

        }

        class ExecuteAction
        {

            public virtual void Execute(Property property) { }

        }

        class ActionActiveObject : ExecuteAction
        {

            public override void Execute(Property property)
            {

                int count = property.Objects.Length;

                for (int i = 0; i < count; i++)
                    property.Objects[i].SetActive(property.ObjectActives[i]);

            }

        }

        class ActionNextScene : ExecuteAction
        {

            public override void Execute(Property property)
            {

                if (property.SceneAnimation == null)
                    YScene.LoadScene(property.SceneName);
                else
                    YScene.LoadScene(property.SceneName);

            }

        }

        class ActionFunction : ExecuteAction
        {

            public override void Execute(Property property)
            {

                property.OnFunction.Invoke();

            }

        }

        public string key;

        [Flags]
        public enum ActionType
        {

            ACTIVE_OBJECT = 1 << 0,
            NEXT_SCENE = 1 << 1,
            FUNTION = 1 << 2,
            COUNT = 3

        }
        public ActionType Type;

        #region ACTIVE_OBJECT Property

        public int size;
        public GameObject[] Objects;
        public bool[] ObjectActives;

        #endregion

        #region NEXT_SCENE Property

        public string SceneName;
        public YAnimation SceneAnimation;

        #endregion

        #region FUNCTION Property

        [SerializeField]
        public FunctionEvent OnFunction = new FunctionEvent();

        #endregion

        private Dictionary<ActionType, ExecuteAction> ExecuteActions;

        public void Init()
        {

            ExecuteActions = new Dictionary<ActionType, ExecuteAction>();

            ExecuteActions.Add(ActionType.ACTIVE_OBJECT, new ActionActiveObject());
            ExecuteActions.Add(ActionType.NEXT_SCENE, new ActionNextScene());
            ExecuteActions.Add(ActionType.FUNTION, new ActionFunction());

        }

        public void Action()
        {

            Init();

            int count = (int)ActionType.COUNT;

            Property property = GetProperty();

            for (int i = 0; i < count; i++)
            {

                ActionType type = (ActionType)(1 << i);

                if (Type.HasFlag(type))
                    ExecuteActions[type].Execute(property);

            }

        }

        private Property GetProperty()
        {

            Property pp = new Property();

            pp.Objects = Objects;
            pp.ObjectActives = ObjectActives;

            pp.SceneName = SceneName;
            pp.SceneAnimation = SceneAnimation;

            pp.OnFunction = OnFunction;

            return pp;

        }

    }

}
