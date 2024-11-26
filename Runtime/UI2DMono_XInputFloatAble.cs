using UnityEngine;
using UnityEngine.Events;


public class UI2DMono_XInputFloatAble : MonoBehaviour
{
    public float m_value;
    public UnityEvent<float> m_onValueChanged;
    public void SetValue(float value)
    {
        m_value = value;
        m_onValueChanged.Invoke(value);
    }
}
