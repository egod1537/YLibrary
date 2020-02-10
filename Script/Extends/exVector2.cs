using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YLibrary
{

    public static class exVector2
    {

        public static GameObject RayCast(this Vector2 vec)
        {

            GameObject collision = null;

            Ray ray = Camera.main.ScreenPointToRay(vec);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                collision = hit.transform.gameObject;

            return collision;

        }

    }

}
