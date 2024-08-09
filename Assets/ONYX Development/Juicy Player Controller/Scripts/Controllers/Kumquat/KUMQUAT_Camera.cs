using UnityEngine;

namespace ONYX
{
    public class KUMQUAT_Camera : MonoBehaviour
    {
        [Header ("Debug/References")]
        [ReadOnly, SerializeField] private KUMQUAT_Character _character;
        [ReadOnly, SerializeField] private Transform _cameraTarget;

        private void Awake()
        {
            _character = transform.parent.GetComponentInChildren<KUMQUAT_Character>();
            _cameraTarget = transform.parent.GetComponentInChildren<KUMQUAT_Camera_Target>().transform;
        }

        private void LateUpdate()
        {
            transform.position = _cameraTarget.position;
            transform.rotation = _cameraTarget.rotation;
        }
    }
}