using System.Collections.Generic;
using UnityEngine;

namespace NebusokuDev.FovMultiple.Runtime
{
    public class MultipleFovSetter : MonoBehaviour
    {
        [SerializeField, Range(1f, 160f)] private float baseFov = 60f;

        private Dictionary<object, float> _virtualFov;
        public IDictionary<object, float> VirtualFov => _virtualFov;
        private IFovSource _source;

        private void Start()
        {
            _source = GetComponent<IFovSource>();
            _virtualFov = new Dictionary<object, float>();
        }


        private void Update()
        {
            var result = 1f;
            
            foreach (var fov in _virtualFov)
            {
                result *= fov.Value;
            }

            _source.FieldOfView = baseFov * result;
        }
    }
}