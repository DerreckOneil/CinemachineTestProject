using UnityEngine;

namespace CinemachineTest.Carlos {
	public class OrbitalMover : MonoBehaviour {
		private const float SqrThreshold = 0.0001f;

		//axis and center are in world space.
		[SerializeField] private float speed = 5;
		[SerializeField] private Vector3 axis = Vector3.forward;
		[SerializeField] private Vector3 center;

		public void OnValidate() {
			float sqrMagnitude = axis.sqrMagnitude;
			if (sqrMagnitude < SqrThreshold) {
				axis = Vector3.forward;
			} else {
				axis /= Mathf.Sqrt(sqrMagnitude);
			}
		}

		public void Update() {
			Vector3 delta = transform.position - center;
			delta = Quaternion.AngleAxis(speed * Time.deltaTime, axis) * delta;
			transform.position = center + delta;
		}

		public void OnDrawGizmosSelected() {
			Color defaultColor = Gizmos.color;
			Gizmos.color = Color.red;
			Gizmos.DrawRay(center, axis);
			Gizmos.DrawWireSphere(center, 0.05f);
			Gizmos.color = defaultColor;
		}
	}
}