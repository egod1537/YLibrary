using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exTransform
    {

        public static Transform ResetTranform(this Transform transform)
        {

            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
            transform.localScale = Vector3.one;

            return transform;

        }

        #region SetTransform

        public static Vector3 SetPosX(this Transform transform, float value)
        {

            Vector3 trPos = transform.position;

            transform.position = new Vector3(
                value, trPos.y, trPos.z);

            return transform.position;

        }
        public static Vector3 SetPosY(this Transform transform, float value)
        {

            Vector3 trPos = transform.position;

            transform.position = new Vector3(
                trPos.x, value, trPos.z);

            return transform.position;

        }
        public static Vector3 SetPosZ(this Transform transform, float value)
        {

            Vector3 trPos = transform.position;

            transform.position = new Vector3(
                trPos.x, trPos.y, value);

            return transform.position;

        }
        public static Vector3 SetPos(this Transform transform, Vector3 value)
        {

            transform.SetPosX(value.x);
            transform.SetPosY(value.y);
            transform.SetPosZ(value.z);

            return value;

        }

        public static Vector3 SetLocalPosX(this Transform transform, float value)
        {

            Vector3 trPos = transform.localPosition;

            transform.localPosition = new Vector3(
                value, trPos.y, trPos.z);

            return transform.localPosition;

        }
        public static Vector3 SetLocalPosY(this Transform transform, float value)
        {

            Vector3 trPos = transform.localPosition;

            transform.localPosition = new Vector3(
                trPos.x, value, trPos.z);

            return transform.localPosition;

        }
        public static Vector3 SetLocalPosZ(this Transform transform, float value)
        {

            Vector3 trPos = transform.localPosition;

            transform.localPosition = new Vector3(
                trPos.x, trPos.y, value);

            return transform.localPosition;

        }
        public static Vector3 SetLocalPos(this Transform transform, Vector3 value)
        {

            transform.SetLocalPosX(value.x);
            transform.SetLocalPosY(value.y);
            transform.SetLocalPosZ(value.z);

            return value;

        }

        public static Vector3 SetRotX(this Transform transform, float value)
        {

            Vector3 trRot = transform.eulerAngles;

            transform.eulerAngles = new Vector3(
                value, trRot.y, trRot.z);

            return transform.eulerAngles;

        }
        public static Vector3 SetRotY(this Transform transform, float value)
        {

            Vector3 trRot = transform.eulerAngles;

            transform.eulerAngles = new Vector3(
                trRot.x, value, trRot.z);

            return transform.eulerAngles;

        }
        public static Vector3 SetRotZ(this Transform transform, float value)
        {

            Vector3 trRot = transform.eulerAngles;

            transform.eulerAngles = new Vector3(
                trRot.x, trRot.y, value);

            return transform.eulerAngles;

        }
        public static Vector3 SetRot(this Transform transform, Vector3 value)
        {

            transform.SetRotX(value.x);
            transform.SetRotY(value.y);
            transform.SetRotZ(value.z);

            return value;

        }

        public static Vector3 SetLocalRotX(this Transform transform, float value)
        {

            Vector3 trRot = transform.localEulerAngles;

            transform.localEulerAngles = new Vector3(
                value, trRot.y, trRot.z);

            return transform.localEulerAngles;

        }
        public static Vector3 SetLocalRotY(this Transform transform, float value)
        {

            Vector3 trRot = transform.localEulerAngles;

            transform.localEulerAngles = new Vector3(
                trRot.x, value, trRot.z);

            return transform.localEulerAngles;

        }
        public static Vector3 SetLocalRotZ(this Transform transform, float value)
        {

            Vector3 trRot = transform.localEulerAngles;

            transform.localEulerAngles = new Vector3(
                trRot.x, trRot.y, value);

            return transform.localEulerAngles;

        }
        public static Vector3 SetLocalRot(this Transform transform, Vector3 value)
        {

            transform.SetLocalRotX(value.x);
            transform.SetLocalRotY(value.y);
            transform.SetLocalRotZ(value.z);

            return value;

        }

        public static Vector3 SetLocalScaleX(this Transform transform, float value)
        {

            Vector3 trScale = transform.localScale;

            transform.localScale = new Vector3(
                value, trScale.y, trScale.z);

            return transform.localScale;

        }
        public static Vector3 SetLocalScaleY(this Transform transform, float value)
        {

            Vector3 trScale = transform.localScale;

            transform.localScale = new Vector3(
                trScale.x, value, trScale.z);

            return transform.localScale;

        }
        public static Vector3 SetLocalScaleZ(this Transform transform, float value)
        {

            Vector3 trScale = transform.localScale;

            transform.localScale = new Vector3(
                trScale.x, trScale.y, value);

            return transform.localScale;

        }
        public static Vector3 SetLocalScale(this Transform transform, Vector3 value)
        {

            transform.SetLocalScaleX(value.x);
            transform.SetLocalScaleY(value.y);
            transform.SetLocalScaleZ(value.z);

            return value;

        }

        #endregion
        #region AddTransform

        public static Vector3 AddPosX(this Transform transform, float value)
        {
            return transform.SetPosX(transform.position.x + value);
        }
        public static Vector3 AddPosY(this Transform transform, float value)
        {
            return transform.SetPosY(transform.position.y + value);
        }
        public static Vector3 AddPosZ(this Transform transform, float value)
        {
            return transform.SetPosZ(transform.position.z + value);
        }
        public static Vector3 AddPos(this Transform transform, Vector3 value)
        {
            return transform.SetPos(transform.position + value);
        }

        public static Vector3 AddLocalPosX(this Transform transform, float value)
        {
            return transform.SetLocalPosX(transform.localPosition.x + value);
        }
        public static Vector3 AddLocalPosY(this Transform transform, float value)
        {
            return transform.SetLocalPosY(transform.localPosition.y + value);
        }
        public static Vector3 AddLocalPosZ(this Transform transform, float value)
        {
            return transform.SetLocalPosZ(transform.localPosition.z + value);
        }
        public static Vector3 AddLocalPos(this Transform transform, Vector3 value)
        {
            return transform.SetLocalPos(transform.localPosition + value);
        }

        public static Vector3 AddRotX(this Transform transform, float value)
        {
            return transform.SetRotX(transform.eulerAngles.x + value);
        }
        public static Vector3 AddRotY(this Transform transform, float value)
        {
            return transform.SetRotY(transform.eulerAngles.y + value);
        }
        public static Vector3 AddRotZ(this Transform transform, float value)
        {
            return transform.SetRotZ(transform.eulerAngles.z + value);
        }
        public static Vector3 AddRot(this Transform transform, Vector3 value)
        {
            return transform.SetRot(transform.eulerAngles + value);
        }

        public static Vector3 AddLocalRotX(this Transform transform, float value)
        {
            return transform.SetLocalRotX(transform.localEulerAngles.x + value);
        }
        public static Vector3 AddLocalRotY(this Transform transform, float value)
        {
            return transform.SetLocalRotY(transform.localEulerAngles.y + value);
        }
        public static Vector3 AddLocalRotZ(this Transform transform, float value)
        {
            return transform.SetLocalRotZ(transform.localEulerAngles.z + value);
        }
        public static Vector3 AddLocalRot(this Transform transform, Vector3 value)
        {
            return transform.SetLocalRot(transform.localEulerAngles + value);
        }

        public static Vector3 AddLocalScaleX(this Transform transform, float value)
        {
            return transform.SetLocalScaleX(transform.localScale.x + value);
        }
        public static Vector3 AddLocalScaleY(this Transform transform, float value)
        {
            return transform.SetLocalScaleY(transform.localScale.y + value);
        }
        public static Vector3 AddLocalScaleZ(this Transform transform, float value)
        {
            return transform.SetLocalScaleZ(transform.localScale.z + value);
        }
        public static Vector3 AddLocalScale(this Transform transform, Vector3 value)
        {
            return transform.SetLocalScale(transform.localScale + value);
        }

        #endregion

        public static void InPool(this Transform transform, string name) => YObjectPool.InPool(name, transform.gameObject);
        public static void InPool(this Transform transform) => YObjectPool.InPool(transform.gameObject.name, transform.gameObject);

    }

}
