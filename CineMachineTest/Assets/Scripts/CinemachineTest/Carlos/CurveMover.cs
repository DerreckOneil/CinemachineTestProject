using UnityEngine;

namespace CinemachineTest.Carlos {
	public class CurveMover : MonoBehaviour {
		[SerializeField] private Vector3 direction = Vector3.forward;
		[SerializeField] private float speed = 5;
		[SerializeField] private float period = 2;
		[SerializeField] private AnimationCurve velocityX;
		[SerializeField] private AnimationCurve velocityY;
		[SerializeField] private AnimationCurve velocityZ;

		private float localTime = 0;

		public void Update() {
			Vector3 v = new Vector3(
				velocityX.Evaluate(localTime),
				velocityY.Evaluate(localTime),
				velocityZ.Evaluate(localTime)
			);

			float dt = Time.deltaTime;
			transform.position += v * dt;
			localTime = (localTime + dt) % period;

		}

		public void OnDrawGizmosSelected() {
			Color defaultColor = Gizmos.color;
			Gizmos.color = Color.red;
			Gizmos.DrawRay(transform.position, direction);
			Gizmos.color = defaultColor;
		}
	}
}