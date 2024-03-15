using System;
using Cinemachine;
using UnityEngine;

namespace CameraShakeManager
{
    [RequireComponent(typeof(CinemachineVirtualCamera))]
    public class CameraShakeComponent : MonoBehaviour, IActivateable
    {
        private IActivateable _manager;
        [SerializeField] private CameraShakeSource[] _sources;
        [SerializeField] private bool _activateOnStart;

        private void Awake()
        {
            _manager = new CameraShakeManager(GetComponent<CinemachineVirtualCamera>()
                .GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>(), _sources);
        }

        private void Start()
        {
            if (!_activateOnStart)
                return;
            _manager.Activate(true);
        }

        public void Activate(bool flag)
        {
            _manager.Activate(flag);
        }
    }
}