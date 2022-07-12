using UnityEngine;

namespace NebusokuDev.FovMultiple.Runtime
{
    public class VFovChanger : MonoBehaviour
    {
        [SerializeField] private MultipleFovSetter multipleFovSetter;
        [SerializeField, Range(0f, 2f)] private float virtualFov = 1f;
        [SerializeField] private float dumpTime = .1f;

        private void Update()
        {
            if (multipleFovSetter.VirtualFov.ContainsKey(this) == false)
            {
                multipleFovSetter.VirtualFov[this] = virtualFov;

                return;
            }


            multipleFovSetter.VirtualFov[this] =
                Mathf.Lerp( multipleFovSetter.VirtualFov[this],virtualFov, Time.deltaTime / dumpTime);
        }
    }
}