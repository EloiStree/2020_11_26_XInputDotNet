using UnityEngine;
using UnityEngine.Events;


namespace Eloi.XInput
{

    public class UI2DMono_XInputFloatRelay : MonoBehaviour
    {
        public float m_value;
        public UnityEvent<float> m_onValueChanged;
        public void SetValue(float value)
        {
            m_value = value;
            m_onValueChanged.Invoke(value);
        }
    }
}