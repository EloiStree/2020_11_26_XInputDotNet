using System;
using UnityEngine;
using UnityEngine.Events;
using XInputDotNetPure;
namespace Eloi.XInput
{

    [System.Serializable]
    public class GamepadJoystickStateToEvent
    {
        public GamePadJoysticksStateValue m_currentState;
        public GamePadJoysticksStateValue m_previousState;
        public UnityEvent<Vector2, Vector2> m_onChanged;
        public bool m_disabled = false;
        private PlayerIndex m_gamepadIndex;

        public GamepadJoystickStateToEvent(PlayerIndex gamepadIndex)
        {
            this.m_gamepadIndex = gamepadIndex;
        }

        public void FetchInputInfo()
        {
            GamePadState state = GamePad.GetState(m_gamepadIndex);
            m_previousState.m_leftStickX = m_currentState.m_leftStickX;
            m_previousState.m_leftStickY = m_currentState.m_leftStickY;
            m_previousState.m_rightStickX = m_currentState.m_rightStickX;
            m_previousState.m_rightStickY = m_currentState.m_rightStickY;

            m_currentState.m_leftStickX = state.ThumbSticks.Left.X;
            m_currentState.m_leftStickY = state.ThumbSticks.Left.Y;
            m_currentState.m_rightStickX = state.ThumbSticks.Right.X;
            m_currentState.m_rightStickY = state.ThumbSticks.Right.Y;
        }
        public void FetchAndPushChangeInputInfo()
        {
            FetchInputInfo();
            PushIfChanged();
        }

        public void SetLeftHorizontal(float value)
        {
            m_previousState.m_leftStickX = m_currentState.m_leftStickX;
            m_currentState.m_leftStickX = value;
        }
        public void SetLeftVertical(float value)
        {
            m_previousState.m_leftStickY = m_currentState.m_leftStickY;
            m_currentState.m_leftStickY = value;
        }
        public void SetRightHorizontal(float value)
        {
            m_previousState.m_rightStickX = m_currentState.m_rightStickX;
            m_currentState.m_rightStickX = value;
        }
        public void SetRightVertical(float value)
        {
            m_previousState.m_rightStickY = m_currentState.m_rightStickY;
            m_currentState.m_rightStickY = value;
        }
        public string m_lastPush = "";
        public void PushIfChanged()
        {
            if (m_previousState.m_leftStickX != m_currentState.m_leftStickX
                || m_previousState.m_leftStickY != m_currentState.m_leftStickY
                || m_previousState.m_rightStickX != m_currentState.m_rightStickX
                || m_previousState.m_rightStickY != m_currentState.m_rightStickY)
            {
                if (m_onChanged != null && !m_disabled)
                {
                    m_lastPush = DateTime.Now.ToString();
                    m_onChanged.Invoke(new Vector2(m_currentState.m_leftStickX, m_currentState.m_leftStickY), new Vector2(m_currentState.m_rightStickX, m_currentState.m_rightStickY));
                }
            }
        }
    }

    [System.Serializable]
    public class GamePadJoysticksStateValue
    {
        public float m_leftStickX;
        public float m_leftStickY;
        public float m_rightStickX;
        public float m_rightStickY;
    }
}