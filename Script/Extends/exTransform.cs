using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exTransform
    {

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
        public static Vector2 SetPos(this Transform transform, Vector3 value)
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
        public static Vector2 SetLocalPos(this Transform transform, Vector3 value)
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
        public static Vector2 SetRot(this Transform transform, Vector3 value)
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
        public static Vector2 SetLocalRot(this Transform transform, Vector3 value)
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
        public static Vector2 SetLocalScale(this Transform transform, Vector3 value)
        {

            transform.SetLocalScaleX(value.x);
            transform.SetLocalScaleY(value.y);
            transform.SetLocalScaleZ(value.z);

            return value;

        }

    }

}
