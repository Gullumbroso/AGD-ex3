using UnityEngine;
using UnityEngine.EventSystems;
using System;
using BatCave;
using Infra.Gameplay.UI;

namespace AssemblyCSharp
{
	[CreateAssetMenu(menuName = "Bat Controller/Mouse")]
	public class BatMouseController: BatController
	{
		bool FlyUp;

		public BatMouseController ()
		{
		}

		protected void OnEnable () {
			GameInputCapture.OnTouchDown += OnTouchDown;
			GameInputCapture.OnTouchUp += OnTouchUp;
		}

		protected void OnDisable () {
			GameInputCapture.OnTouchDown -= OnTouchDown;
			GameInputCapture.OnTouchUp -= OnTouchUp;
		}

		private void OnTouchDown(PointerEventData e) {
			FlyUp = true;
		}

		private void OnTouchUp(PointerEventData e) {
			FlyUp = false;
		}

		public override bool WantsToFlyUp() {
			return FlyUp; 
		}
	}
}

