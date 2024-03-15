using Cinemachine;
using DG.Tweening;

namespace CameraShakeManager
{
    public class CameraShakeManager : IActivateable
    {
        private readonly ICameraShakeSource[] _sources;
        private readonly CinemachineBasicMultiChannelPerlin _multiChannelPerlin;
        private Tween _amplitudeGain;
        private Tween _frequencyGain;
        
        public CameraShakeManager(CinemachineBasicMultiChannelPerlin multiChannelPerlin, ICameraShakeSource[] sources)
        {
            _multiChannelPerlin = multiChannelPerlin;
            _sources = sources;
            ResetNoise();
        }
        
        private void ResetNoise()
        {
            _multiChannelPerlin.m_AmplitudeGain = 0f;
            _multiChannelPerlin.m_FrequencyGain = 0f;
        }

        private void UpdateAmplitudeGain(float amplitude, float duration)
        {
            _amplitudeGain?.Kill();
            _amplitudeGain = DOVirtual.Float(amplitude, 0f, duration, value =>
            {
                _multiChannelPerlin.m_AmplitudeGain = value;
            }).SetEase(Ease.OutQuad);
        }

        private void UpdateFrequencyGain(float frequency, float duration)
        {
            _frequencyGain?.Kill();
            _frequencyGain = DOVirtual.Float(frequency, 0f, duration, value =>
            {
                _multiChannelPerlin.m_FrequencyGain = value;
            }).SetEase(Ease.OutQuad);
        }

        private void RegisterToSources()
        {
            foreach (var source in _sources)
            {
                source.Shaked += CameraShakeSource_Shaked;
            }
        }

        private void UnregisterFromSources()
        {
            foreach (var source in _sources)
            {
                source.Shaked -= CameraShakeSource_Shaked;
            }
        }

        private void CameraShakeSource_Shaked(CameraShakeSourceData data)
        {
            UpdateAmplitudeGain(data.Amplitude, data.Duration);
            UpdateFrequencyGain(data.Frequency, data.Duration);
        }

        public void Activate(bool flag)
        {
            if(flag)
                RegisterToSources();
            else
                UnregisterFromSources();
        }
    }
}