using UnityEngine;

namespace PUCS.Scripts
{
    [RequireComponent(typeof(PucsCamera))]
    public class PucsSidescrollCamera : MonoBehaviour
    {
        private PucsCamera _pucsCamera;

        private void Awake()
        {
            _pucsCamera = GetComponent<PucsCamera>();
        }
    }
}