using UnityEngine;

namespace NebusokuDev.FovMultiple.Runtime
{
    public class AdditionalFovMultipleCameraData : MonoBehaviour, IFovSource
    {
        private Camera _camera;

        private void Awake() => _camera = GetComponent<Camera>();

        public float FieldOfView
        {
            get => _camera.fieldOfView;
            set => _camera.fieldOfView = value;
        }
    }
}