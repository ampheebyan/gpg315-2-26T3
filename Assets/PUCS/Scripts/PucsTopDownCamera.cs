using System;
using UnityEngine;

namespace PUCS.Scripts
{
    [RequireComponent(typeof(PucsCamera))]
    public class PucsTopDownCamera : MonoBehaviour
    {
        private PucsCamera _pucsCamera;

        private void Awake()
        {
            _pucsCamera = GetComponent<PucsCamera>();
        }
    }
}