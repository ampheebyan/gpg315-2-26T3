using System;
using UnityEngine;

namespace PUCS.Scripts
{
    // base camera that all other camera scripts require
    public class PucsCamera : MonoBehaviour
    {
        private Camera _cam;
        public Camera Camera => _cam;
        
        public PucsCameraSettings cameraSettings;
        public virtual void Awake()
        {
            if (cameraSettings == null)
            {
                PucsLogger.Log("No camera settings, assuming defaults.");
                cameraSettings = ScriptableObject.CreateInstance<PucsCameraSettings>();
            }
            
            if (_cam == null)
            {
                PucsLogger.Log("No camera assigned, attempting to find camera on current GameObject.", LogType.Warning);
                if (TryGetComponent(out _cam))
                {
                    PucsLogger.Log("Camera found on current GameObject.");
                    SetCameraSettings();
                }
                else
                {
                    PucsLogger.Log("Camera not found on current GameObject, disabling.", LogType.Error);
                    enabled = false;
                }
            }
            else
            {
                SetCameraSettings();
            }
        }

        private void SetCameraSettings()
        {
            _cam.orthographic = cameraSettings.orthographic;
            _cam.orthographicSize = cameraSettings.orthographicSize;
        }

        private void OnValidate()
        {
            if (_cam && cameraSettings) SetCameraSettings();
        }
    }
}