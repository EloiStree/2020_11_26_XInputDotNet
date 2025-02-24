using UnityEngine;
using UnityEngine.Events;

public class UI2DMono_XInputJoystickAble : MonoBehaviour
{
    public Vector2 m_value;
    public UnityEvent<Vector2> m_onValueChanged;
    public UnityEvent<float > m_onXChanged;
    public UnityEvent<float > m_onYChanged;
    public void SetValue(Vector2 value)
    {
        m_value = value;
        m_onValueChanged.Invoke(value);
        m_onXChanged.Invoke(value.x);
        m_onYChanged.Invoke(value.y);
    }
}
