using UnityEngine;

namespace CinemachineTest.Carlos {
	public class LinearMover : MonoBehaviour {
		private const float SqrThreshold = 0.0001f;

		[SerializeField] private Vector3 direction = Vector3.forward;
		[SerializeField] private float speed = 5;

		public void OnValidate() {
			float sqrMagnitude = direction.sqrMagnitude;
			if (sqrMagnitude < SqrThreshold) {
				direction = Vector3.forward;
			} else {
				direction /= Mathf.Sqrt(sqrMagnitude);
			}
		}

		public void Update() {
			transform.position += direction * speed * Time.deltaTime;
		}

		public void OnDrawGizmosSelected() {
			
		}
	}
}