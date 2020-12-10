using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace clicker
{
    public class ClickerButton : MonoBehaviour
    {
        public static System.Action OnClick;
        public void ClickHandler()
        {
            if (OnClick != null) {
                OnClick();
            }
        }
    }
}
