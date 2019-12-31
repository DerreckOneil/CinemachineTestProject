using UnityEngine;

namespace CinemachineTest.Carlos {
	public class OrbitalMover : MonoBehaviour {
		private const float SqrThreshold = 0.0001f;

		[SerializeField] private Vector3 axis = Vector3.forward;
		[SerializeField] private float speed = 5;

		public void OnValidate() {
			float sqrMagnitude = axis.sqrMagnitude;
			if (sqrMagnitude < SqrThreshold) {
				axis = Vector3.forward;
			} else {
				axis /= Mathf.Sqrt(sqrMagnitude);
			}
		}

		public void Update() {
			transform.position += axis * speed * Time.deltaTime;
		}
	}
}