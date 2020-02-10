using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exGameObject
    {

        public static Vector3 SetPosX(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.position;

            gameobject.transform.position = new Vector3(
                value, trPos.y, trPos.z);

            return gameobject.transform.position;

        }
        public static Vector3 SetPosY(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.position;

            gameobject.transform.position = new Vector3(
                trPos.x, value, trPos.z);

            return gameobject.transform.position;

        }
        public static Vector3 SetPosZ(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.position;

            gameobject.transform.position = new Vector3(
                trPos.x, trPos.y, value);

            return gameobject.transform.position;

        }
        public static Vector2 SetPos(this GameObject gameobject, Vector3 value)
        {

            gameobject.SetPosX(value.x);
            gameobject.SetPosY(value.y);
            gameobject.SetPosZ(value.z);

            return value;

        }

        public static Vector3 SetLocalPosX(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.localPosition;

            gameobject.transform.localPosition = new Vector3(
                value, trPos.y, trPos.z);

            return gameobject.transform.localPosition;

        }
        public static Vector3 SetLocalPosY(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.localPosition;

            gameobject.transform.localPosition = new Vector3(
                trPos.x, value, trPos.z);

            return gameobject.transform.localPosition;

        }
        public static Vector3 SetLocalPosZ(this GameObject gameobject, float value)
        {

            Vector3 trPos = gameobject.transform.localPosition;

            gameobject.transform.localPosition = new Vector3(
                trPos.x, trPos.y, value);

            return gameobject.transform.localPosition;

        }
        public static Vector2 SetLocalPos(this GameObject gameobject, Vector3 value)
        {

            gameobject.SetLocalPosX(value.x);
            gameobject.SetLocalPosY(value.y);
            gameobject.SetLocalPosZ(value.z);

            return value;

        }

        public static Vector3 SetRotX(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.eulerAngles;

            gameobject.transform.eulerAngles = new Vector3(
                value, trRot.y, trRot.z);

            return gameobject.transform.eulerAngles;

        }
        public static Vector3 SetRotY(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.eulerAngles;

            gameobject.transform.eulerAngles = new Vector3(
                trRot.x, value, trRot.z);

            return gameobject.transform.eulerAngles;

        }
        public static Vector3 SetRotZ(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.eulerAngles;

            gameobject.transform.eulerAngles = new Vector3(
                trRot.x, trRot.y, value);

            return gameobject.transform.eulerAngles;

        }
        public static Vector2 SetRot(this GameObject gameobject, Vector3 value)
        {

            gameobject.SetRotX(value.x);
            gameobject.SetRotY(value.y);
            gameobject.SetRotZ(value.z);

            return value;

        }

        public static Vector3 SetLocalRotX(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.localEulerAngles;

            gameobject.transform.localEulerAngles = new Vector3(
                value, trRot.y, trRot.z);

            return gameobject.transform.localEulerAngles;

        }
        public static Vector3 SetLocalRotY(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.localEulerAngles;

            gameobject.transform.localEulerAngles = new Vector3(
                trRot.x, value, trRot.z);

            return gameobject.transform.localEulerAngles;

        }
        public static Vector3 SetLocalRotZ(this GameObject gameobject, float value)
        {

            Vector3 trRot = gameobject.transform.localEulerAngles;

            gameobject.transform.localEulerAngles = new Vector3(
                trRot.x, trRot.y, value);

            return gameobject.transform.localEulerAngles;

        }
        public static Vector2 SetLocalRot(this GameObject gameobject, Vector3 value)
        {

            gameobject.SetLocalRotX(value.x);
            gameobject.SetLocalRotY(value.y);
            gameobject.SetLocalRotZ(value.z);

            return value;

        }

        public static Vector3 SetLocalScaleX(this GameObject gameobject, float value)
        {

            Vector3 trScale = gameobject.transform.localScale;

            gameobject.transform.localScale = new Vector3(
                value, trScale.y, trScale.z);

            return gameobject.transform.localScale;

        }
        public static Vector3 SetLocalScaleY(this GameObject gameobject, float value)
        {

            Vector3 trScale = gameobject.transform.localScale;

            gameobject.transform.localScale = new Vector3(
                trScale.x, value, trScale.z);

            return gameobject.transform.localScale;

        }
        public static Vector3 SetLocalScaleZ(this GameObject gameobject, float value)
        {

            Vector3 trScale = gameobject.transform.localScale;

            gameobject.transform.localScale = new Vector3(
                trScale.x, trScale.y, value);

            return gameobject.transform.localScale;

        }
        public static Vector2 SetLocalScale(this GameObject gameobject, Vector3 value)
        {

            gameobject.SetLocalScaleX(value.x);
            gameobject.SetLocalScaleY(value.y);
            gameobject.SetLocalScaleZ(value.z);

            return value;

        }

    }

}
