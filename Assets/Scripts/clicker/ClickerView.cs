using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace clicker
{
    public class ClickerView : MonoBehaviour
    {
        public Text labelObj;

        public void UpdateLabel(int score)
        {
            this.labelObj.text = score.ToString();
        }
    }
}
