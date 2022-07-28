using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SashaBeechJones
{
    public class EventManager : MonoBehaviour
    {

        public delegate void ClickAction();

        public static event ClickAction OnClicked;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (OnClicked != null)
                {
                    OnClicked();
                }
            }
        }
    }
}

