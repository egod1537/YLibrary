using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace YLibrary
{

    public class YScript : MonoBehaviour
    {

        protected void SubscribeOnDestory(UnityAction callback)
        {

            void Temp(Scene current, Scene next) => callback();

            SceneManager.activeSceneChanged += Temp;

        }

    }

}
