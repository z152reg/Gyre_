using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spawner
{
    public class ObjectsPool : MonoBehaviour
    {
        protected List<PoolableObject> objects;
        public void Init()
        {
            this.objects = new List<PoolableObject>( this.GetComponentsInChildren<PoolableObject>(true) );
            this.objects.ForEach(o => {
                o.gameObject.SetActive(false);
            });
        }
        public PoolableObject GetObject()
        {
            int c = this.objects.Count;
            PoolableObject targetObj = null;
            for (int i = 0; i < c; i++) {
                if (!this.objects[i].gameObject.activeSelf) {
                    targetObj = this.objects[i];
                    break;
                }
            }
            if (targetObj == null && c > 0) {
                targetObj = Instantiate(this.objects[0],this.objects[0].transform.parent,false);
                targetObj.gameObject.SetActive(false);
                objects.Add(targetObj);
            }
            targetObj.GetTransform().localPosition = Vector3.zero;
            return targetObj;
        }
    }
}
