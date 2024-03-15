using UnityEditor;
using UnityEngine;

namespace CameraShakeManager
{
    [CustomEditor(typeof(CameraShakeSource))]
    public class CameraShakeSourceEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var cameraShakeSource = (CameraShakeSource)target;
            if (GUILayout.Button("Shake"))
            {
                cameraShakeSource.OnShake();
            }
        }
    }
}