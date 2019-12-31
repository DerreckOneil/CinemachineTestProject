using UnityEngine;

namespace CinemachineTest.Derreck
{
    public class Movement : MonoBehaviour
    {
        [Range(-1,10)]
        [SerializeField] private float speedValue = 5;
        public void Update()
        {
            transform.Translate(Vector3.up * Time.deltaTime * speedValue);
        }
    }
}