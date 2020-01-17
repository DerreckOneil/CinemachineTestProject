using UnityEngine;
using System.Collections;
namespace CinemachineTest.Derreck
{
    public class SphereMovement : MonoBehaviour
    {
        [SerializeField]
        private AnimationCurve xCurve;
        public void Update()
        {
            //Vector3 newPos = new Vector3(xCurve.Evaluate(0), xCurve.Evaluate(0), 0);
            //transform.position = newPos;
        }
    }
}