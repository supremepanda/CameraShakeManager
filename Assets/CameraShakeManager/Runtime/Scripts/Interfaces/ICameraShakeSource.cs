using System;

namespace CameraShakeManager
{
    public interface ICameraShakeSource
    {
        public event Action<CameraShakeSourceData> Shaked; 
    }
}