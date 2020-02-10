using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YLibrary;

namespace YLibrary
{

    public class BtnNextScene : ButtonHandler
    {

        public string scene_name;
        
        public override void OnButtonClickUp()
        {

            YScene.LoadScene(scene_name);

        }

    }


}