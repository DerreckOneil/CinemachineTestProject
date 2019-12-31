using UnityEngine;
using System.Collections;
using Cinemachine;


namespace CinemachineTest.Derreck
{
    
    public class VCManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject camera1;
        [SerializeField]
        private GameObject camera2;
        [SerializeField]
        private Camera cam;
        Movement MovementScript;
        [SerializeField]
        private GameObject cube;
        YieldInstruction waitInterval = new WaitForSeconds(5);
        public void Update()
        {

            StartCoroutine(Camera());
        }
        public void Awake()
        {
            MovementScript = cube.GetComponent<Movement>();
            MovementScript.enabled = false;
        }
        private IEnumerator Camera()
        {
            
            yield return waitInterval;
            Debug.Log("Changing Priority!");
            camera2.GetComponent<CinemachineVirtualCamera>().Priority = 1;
            MovementScript.enabled = true;
            yield return waitInterval;

        }
    }
}