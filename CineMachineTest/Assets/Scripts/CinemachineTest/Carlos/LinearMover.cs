using UnityEngine;

namespace CinemachineTest.Carlos {
	public class LinearMover : MonoBehaviour {
		private const float SqrThreshold = 0.0001f;

		[SerializeField] private Vector3 direction = Vector3.forward;
		[SerializeField] private float speed = 5;

		[Header("Ping Pong Options")]
		[SerializeField] private bool pingPong = false;
		[SerializeField] private float pingPongDistance = 10;


		private Vector3 pingPoint;
		private float pingMultiplier = 1;

		public void OnValidate() {
			float sqrMagnitude = direction.sqrMagnitude;
			if (sqrMagnitude < SqrThreshold) {
				direction = Vector3.forward;
			} else {
				direction /= Mathf.Sqrt(sqrMagnitude);
			}
		}

		public void Awake() {
			pingPoint = transform.position;
		}

		public void Update() {
			Vector3 pos = transform.position;
			if (Vector3.SqrMagnitude(pos - pingPoint) >= pingPongDistance * pingPongDistance) {
				pingMultiplier *= -1;
				pingPoint = pos;
			}
			transform.position = pos + direction * speed * pingMultiplier * Time.deltaTime;
		}

		public void OnDrawGizmosSelected() {
			Color defaultColor = Gizmos.color;
			Gizmos.color = Color.red;
			Gizmos.DrawRay(transform.position, direction);
			Gizmos.color = defaultColor;
		}
	}
}