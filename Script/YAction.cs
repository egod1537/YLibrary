using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace YLibrary
{

    [Serializable]
    public class YAction : MonoBehaviour
    {

        public int size;

        public string[] ActionName;

        public YActionBehaviour[] Actions;

        public FunctionEvent[] Functions;

        public void Action(string name)
        {

            Actions[FindAnimation(name)].Action();

        }

        public int FindAnimation(string str)
        {

            int num = -1;

            int i = 0;
            foreach (YActionBehaviour action in Actions)
            {

                if(action.key == str)
                {

                    num = i;
                    break;

                }

                i++;

            }

            return num;

        }

    }

}
