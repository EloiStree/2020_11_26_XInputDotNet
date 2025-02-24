using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2DMono_MoveAnchorAsJoystick : MonoBehaviour
{

    public Vector2 m_joystickValue;
    public RectTransform m_container;
    public RectTransform m_joystick;
    public float m_joystickPercentOfContainer=0.4f;




    public void SetJoystickValue(Vector2 value) {

        value.x = Mathf.Clamp(value.x, -1, 1);
        value.y = Mathf.Clamp(value.y, -1, 1);

        m_joystickValue = value;
    }

    public void OnValidate() {

        Update();
    }
    void Update()
    {

        m_joystickValue.x = Mathf.Clamp(m_joystickValue.x, -1, 1);
        m_joystickValue.y = Mathf.Clamp(m_joystickValue.y, -1, 1);

        m_joystick.anchoredPosition = new Vector2(m_joystickValue.x * m_container.rect.width * m_joystickPercentOfContainer, m_joystickValue.y * m_container.rect.height * m_joystickPercentOfContainer);
        
    }
}
