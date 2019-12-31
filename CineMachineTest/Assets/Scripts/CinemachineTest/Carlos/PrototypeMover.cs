using System;
using UnityEngine;
using CinemachineTest.Derreck;

using VirtualCameraTester = CinemachineTest.Derreck.VirtualCameraTester;

namespace CinemachineTest.Carlos {
	public abstract class PrototypeMover : MonoBehaviour {
		[Serializable]
		public enum Type {
			None = 0,
			Linear = 1,
			Orbital = 2,
			PingPong = 3
		}

		public void Awake() {
			
		}
	}
}