using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spawner
{
    public class SpawnerController : MonoBehaviour
    {
        public SpawnerUI viewUI;
        public ObjectsPool pool;
        private SpawnerModel model = new SpawnerModel();
        private float timing;
        void OnEnable()
        {
            this.timing = this.model.interval;
            this.pool.Init();
            this.viewUI.UpdateUI(this.model.speed,this.model.distance,this.model.interval);
            this.viewUI.SpeedChanged += ChangedSpeed;
            this.viewUI.IntervalChanged += ChangedInterval;
            this.viewUI.DistChanged += ChangedDistance;
        }
        void Update()
        {
            this.timing += Time.deltaTime;
            if (this.timing >= this.model.interval) {
                this.timing = 0;
                this.Spawn();
            }
        }
        void ChangedSpeed(float val)
        {
            this.model.speed = val;
        }
        void ChangedDistance(float val)
        {
            this.model.distance = val;
        }
        void ChangedInterval(float val)
        {
            this.model.interval = val;
        }
        void Spawn()
        {
            PoolableObject createdObj = this.pool.GetObject();
            createdObj.Setup(this.model.speed,this.model.distance);
            createdObj.Activate();
        }
    }
}
