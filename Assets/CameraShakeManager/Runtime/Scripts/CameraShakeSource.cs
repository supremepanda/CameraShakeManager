using System;
using UnityEngine;

namespace CameraShakeManager
{
    [CreateAssetMenu(fileName = "Camera Shake Source", menuName = "Camera Shake Source", order = 0)]
    public class CameraShakeSource : ScriptableObject, ICameraShakeSource
    {
        public event Action<CameraShakeSourceData> Shaked; 
        [SerializeField] private float _amplitudeGain;
        [SerializeField] private float _frequencyGain;
        [SerializeField] private float _duration;
        
        public void OnShake()
        {
            Shaked?.Invoke(new CameraShakeSourceData(_amplitudeGain, _frequencyGain, _duration));
        }
    }
}