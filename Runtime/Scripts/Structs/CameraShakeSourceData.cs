namespace CameraShakeManager
{
    public struct CameraShakeSourceData
    {
        public float Amplitude { get; private set; }
        public float Frequency { get; private set; }
        public float Duration { get; private set; }

        public CameraShakeSourceData(float amplitude, float frequency, float duration)
        {
            Amplitude = amplitude;
            Frequency = frequency;
            Duration = duration;
        }
    }
}