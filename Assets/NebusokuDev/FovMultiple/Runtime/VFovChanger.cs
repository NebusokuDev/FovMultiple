using UnityEngine;

namespace NebusokuDev.FovMultiple.Runtime
{
    public class VFovChanger : MonoBehaviour
    {
        [SerializeField] private MultipleCameraFovSetter multipleCameraFovSetter;
        [SerializeField, Range(0f, 2f)] private float virtualFov = 1f;
        [SerializeField] private float dumpTime = .1f;

        private void Update()
        {
            if (multipleCameraFovSetter.VirtualFov.ContainsKey(this) == false)
            {
                multipleCameraFovSetter.VirtualFov[this] = virtualFov;

                return;
            }


            multipleCameraFovSetter.VirtualFov[this] =
                Mathf.Lerp( multipleCameraFovSetter.VirtualFov[this],virtualFov, Time.deltaTime / dumpTime);
        }
    }
}