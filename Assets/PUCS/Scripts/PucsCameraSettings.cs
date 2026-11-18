using UnityEngine;

namespace PUCS.Scripts
{
    [CreateAssetMenu(fileName = "PucsCameraSettings", menuName = "PUCS Camera Settings", order = 0)]
    public class PucsCameraSettings : ScriptableObject
    {
        public float shakeIntensity;
        public Vector2 zoomRange;
        public bool orthographic;
        public float orthographicSize;
        public float followSpeed;
        public float followDistance;
    }
}