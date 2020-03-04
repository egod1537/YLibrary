using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exGameObject
    {

        public static Transform ResetTransform(this GameObject gameobject)
        {

            gameobject.transform.localPosition = Vector3.zero;
            gameobject.transform.localEulerAngles = Vector3.zero;
            gameobject.transform.localScale = Vector3.one;

            return gameobject.transform;

        }

        #region SetTransform

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

        #endregion
        #region AddTransform

        public static Vector3 AddRotX(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetRotX(gameobject.transform.eulerAngles.x + value);
        }
        public static Vector3 AddRotY(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetRotY(gameobject.transform.eulerAngles.y + value);
        }
        public static Vector3 AddRotZ(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetRotZ(gameobject.transform.eulerAngles.z + value);
        }
        public static Vector3 AddRot(this GameObject gameobject, Vector3 value)
        {
            return gameobject.transform.SetRot(gameobject.transform.eulerAngles + value);
        }

        public static Vector3 AddLocalRotX(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalRotX(gameobject.transform.localEulerAngles.x + value);
        }
        public static Vector3 AddLocalRotY(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalRotY(gameobject.transform.localEulerAngles.y + value);
        }
        public static Vector3 AddLocalRotZ(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalRotZ(gameobject.transform.localEulerAngles.z + value);
        }
        public static Vector3 AddLocalRot(this GameObject gameobject, Vector3 value)
        {
            return gameobject.transform.SetLocalRot(gameobject.transform.localEulerAngles + value);
        }

        public static Vector3 AddLocalScaleX(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalScaleX(gameobject.transform.localScale.x + value);
        }
        public static Vector3 AddLocalScaleY(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalScaleY(gameobject.transform.localScale.y + value);
        }
        public static Vector3 AddLocalScaleZ(this GameObject gameobject, float value)
        {
            return gameobject.transform.SetLocalScaleZ(gameobject.transform.localScale.z + value);
        }
        public static Vector3 AddLocalScale(this GameObject gameobject, Vector3 value)
        {
            return gameobject.transform.SetLocalScale(gameobject.transform.localScale + value);
        }

        #endregion

        public static void InPool(this GameObject gameobject, string name) => YObjectPool.InPool(name, gameobject);
        public static void InPool(this GameObject gameobject) => YObjectPool.InPool(gameobject.name, gameobject);

    }

}
