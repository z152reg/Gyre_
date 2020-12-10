using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace spawner
{
    public class SpawnerUI : MonoBehaviour
    {
        public InputField speedInput;
        public InputField distanceInput;
        public InputField intervalInput;
        public System.Action<float> SpeedChanged;
        public System.Action<float> DistChanged;
        public System.Action<float> IntervalChanged;

        public void UpdateUI(float speedVal, float distVal, float inVal)
        {
            this.speedInput.text = speedVal.ToString("##");
            this.distanceInput.text = distVal.ToString("##");
            this.intervalInput.text = inVal.ToString("##");
        }
        public void SpeedFieldChanged(string val)
        {
            float value = 0;
            if (float.TryParse(val, out value) && SpeedChanged != null) {
                SpeedChanged(value);
            }
            //more actions...
        }
        public void DistanceFieldChanged(string val)
        {
            float value = 0;
            if (float.TryParse(val, out value) && DistChanged != null) {
                DistChanged(value);
            }
            //more actions...
        }
        public void IntervalFieldChanged(string val)
        {
            float value = 0;
            if (float.TryParse(val, out value) && IntervalChanged != null) {
                IntervalChanged(value);
            }
            //more actions...
        }
    }
}
