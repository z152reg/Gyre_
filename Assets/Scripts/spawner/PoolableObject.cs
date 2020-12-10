using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace spawner
{
    public class PoolableObject : MonoBehaviour
    {
        private float distance = 0f;
        private float speed = 0f;
        private Transform objTransform;
        private Vector3 startPos;
        public Transform GetTransform()
        {
            if (this.objTransform == null) {
                this.objTransform = this.transform;
            }
            return this.objTransform;
        }
        void OnEnable()
        {
            this.startPos = this.objTransform.position;
        }
        public void Setup(float speedValue, float distanceValue)
        {
            this.speed = speedValue;
            this.distance = distanceValue;
        }
        public void Activate()
        {
            this.gameObject.SetActive(true);
        }
        void Update()
        {
            this.objTransform.Translate(Vector3.forward * Time.deltaTime * this.speed,Space.Self);
            if (Vector3.Distance(this.startPos,this.objTransform.position) >= this.distance) {
                this.gameObject.SetActive(false);
            }
        }
    }
}
