using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace clicker
{
    public class ClickerController : MonoBehaviour
    {
        public ClickerView view;
        private ClickerModel model;
        void Awake()
        {
            this.model = new ClickerModel();
        }
        void OnEnable()
        {
            ClickerButton.OnClick += ClickHandler;
        }
        void OnDisable()
        {
            ClickerButton.OnClick -= ClickHandler;
        }
        void Start()
        {
            this.FactoryView();
        }
        private void ClickHandler()
        {
            this.model.AddScore();
            this.FactoryView();
        }
        private void FactoryView()
        {
            this.view.UpdateLabel(this.model.GetScore());
        }
    }
}
