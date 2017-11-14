using UnityEngine;
using System;
using BatCave;

namespace AssemblyCSharp
{
	[CreateAssetMenu(menuName = "Bat Controller/Keyboard")]
	public class BatKeyboardController: BatController
	{
		public BatKeyboardController ()
		{
		}

		public override bool WantsToFlyUp() {
			return Input.GetKeyDown (KeyCode.Space);
		}
	}
}

