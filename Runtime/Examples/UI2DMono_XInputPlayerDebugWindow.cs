using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XInputDotNetPure;


[System.Serializable]
public struct GamePadStateValue { 

    public bool m_isConnected;
    public bool m_a;
    public bool m_b;
    public bool m_x;
    public bool m_y;
    public bool m_start;
    public bool m_back;
    public bool m_leftShoulder;
    public bool m_rightShoulder;
    public bool m_leftStick;
    public bool m_rightStick;
    public bool m_arrowLeft;
    public bool m_arrowRight;
    public bool m_arrowUp;
    public bool m_arrowDown;
    public bool m_menuLeft;
    public bool m_menuRight;
    public bool m_menuCenter;
    public float m_leftTrigger;
    public float m_rightTrigger;
    public float m_leftStickX;
    public float m_leftStickY;
    public float m_rightStickX;
    public float m_rightStickY;

}

public class UI2DMono_XInputPlayerDebugWindow : MonoBehaviour
{

    public PlayerIndex m_playerIndex;
    GamePadState m_state;
    public GamePadStateValue m_currentState;
    public GamePadStateValue m_previousState;



    public UI2DMono_XInputOnOffAble m_pressA;
    public UI2DMono_XInputOnOffAble m_pressB;
    public UI2DMono_XInputOnOffAble m_pressX;
    public UI2DMono_XInputOnOffAble m_pressY;
    public UI2DMono_XInputOnOffAble m_pressLeftShoulder;
    public UI2DMono_XInputOnOffAble m_pressRightShoulder;
    public UI2DMono_XInputOnOffAble m_pressLeftStick;
    public UI2DMono_XInputOnOffAble m_pressRightStick;
    public UI2DMono_XInputOnOffAble m_pressArrowLeft;
    public UI2DMono_XInputOnOffAble m_pressArrowRight;
    public UI2DMono_XInputOnOffAble m_pressArrowUp;
    public UI2DMono_XInputOnOffAble m_pressArrowDown;
    public UI2DMono_XInputOnOffAble m_pressMenuLeft;
    public UI2DMono_XInputOnOffAble m_pressMenuCenter;
    public UI2DMono_XInputOnOffAble m_pressMenuRight;
    public UI2DMono_XInputFloatAble  m_leftTrigger;
    public UI2DMono_XInputFloatAble  m_rightTrigger;
    public UI2DMono_XInputJoystickAble m_leftStick;
    public UI2DMono_XInputJoystickAble m_rightStick
        ;
    

    public bool m_useUpdate=true;
    void Update()
    {
        m_previousState = m_currentState;
        m_state= GamePad.GetState(m_playerIndex);
        

        m_currentState.m_isConnected=m_state.IsConnected;
        m_currentState.m_a=m_state.Buttons.A==ButtonState.Pressed;
        m_currentState.m_b=m_state.Buttons.B==ButtonState.Pressed;
        m_currentState.m_x=m_state.Buttons.X==ButtonState.Pressed;
        m_currentState.m_y=m_state.Buttons.Y==ButtonState.Pressed;
        m_currentState.m_start=m_state.Buttons.Start==ButtonState.Pressed;
        m_currentState.m_back=m_state.Buttons.Back==ButtonState.Pressed;
        m_currentState.m_leftShoulder=m_state.Buttons.LeftShoulder==ButtonState.Pressed;
        m_currentState.m_rightShoulder=m_state.Buttons.RightShoulder==ButtonState.Pressed;
        m_currentState.m_leftStick=m_state.Buttons.LeftStick==ButtonState.Pressed;
        m_currentState.m_rightStick=m_state.Buttons.RightStick==ButtonState.Pressed;
        m_currentState.m_arrowLeft=m_state.DPad.Left==ButtonState.Pressed;
        m_currentState.m_arrowRight=m_state.DPad.Right==ButtonState.Pressed;
        m_currentState.m_arrowUp=m_state.DPad.Up==ButtonState.Pressed;
        m_currentState.m_arrowDown=m_state.DPad.Down==ButtonState.Pressed;
        m_currentState.m_menuLeft=m_state.Buttons.Back== ButtonState.Pressed;
        m_currentState.m_menuRight=m_state.Buttons.Start==ButtonState.Pressed;
        m_currentState.m_menuCenter=m_state.Buttons.Guide==ButtonState.Pressed;
        m_currentState.m_leftTrigger=m_state.Triggers.Left;
        m_currentState.m_rightTrigger=m_state.Triggers.Right;
        m_currentState.m_leftStickX=m_state.ThumbSticks.Left.X;
        m_currentState.m_leftStickY=m_state.ThumbSticks.Left.Y;
        m_currentState.m_rightStickX=m_state.ThumbSticks.Right.X;
        m_currentState.m_rightStickY=m_state.ThumbSticks.Right.Y;

        if(m_previousState.m_a!=m_currentState.m_a)
            if(m_pressA!=null)
            m_pressA.SetOnOff(m_currentState.m_a);
        if(m_previousState.m_b!=m_currentState.m_b)
            if(m_pressB!=null)
            m_pressB.SetOnOff(m_currentState.m_b);
        if(m_previousState.m_x!=m_currentState.m_x)
            if(m_pressX!=null)
            m_pressX.SetOnOff(m_currentState.m_x);
        if(m_previousState.m_y!=m_currentState.m_y)
            if(m_pressY!=null)
            m_pressY.SetOnOff(m_currentState.m_y);
        if(m_previousState.m_leftShoulder!=m_currentState.m_leftShoulder)
            if(m_pressLeftShoulder!=null)
            m_pressLeftShoulder.SetOnOff(m_currentState.m_leftShoulder);
        if(m_previousState.m_rightShoulder!=m_currentState.m_rightShoulder)
            if(m_pressRightShoulder!=null)
            m_pressRightShoulder.SetOnOff(m_currentState.m_rightShoulder);
        if(m_previousState.m_leftStick!=m_currentState.m_leftStick)
            if(m_pressLeftStick!=null)
            m_pressLeftStick.SetOnOff(m_currentState.m_leftStick);
        if(m_previousState.m_rightStick!=m_currentState.m_rightStick)
            if(m_pressRightStick!=null)
            m_pressRightStick.SetOnOff(m_currentState.m_rightStick);
        if(m_previousState.m_arrowLeft!=m_currentState.m_arrowLeft)
                if(m_pressArrowLeft!=null)
            m_pressArrowLeft.SetOnOff(m_currentState.m_arrowLeft);
        if(m_previousState.m_arrowRight!=m_currentState.m_arrowRight)
            if(m_pressArrowRight!=null)
            m_pressArrowRight.SetOnOff(m_currentState.m_arrowRight);
        if(m_previousState.m_arrowUp!=m_currentState.m_arrowUp)
            if(m_pressArrowUp!=null)
            m_pressArrowUp.SetOnOff(m_currentState.m_arrowUp);
        if(m_previousState.m_arrowDown!=m_currentState.m_arrowDown)
            if(m_pressArrowDown!=null)
            m_pressArrowDown.SetOnOff(m_currentState.m_arrowDown);
        if(m_previousState.m_menuLeft!=m_currentState.m_menuLeft)
            if(m_pressMenuLeft!=null)
            m_pressMenuLeft.SetOnOff(m_currentState.m_menuLeft);
        if(m_previousState.m_menuRight!=m_currentState.m_menuRight)
            if(m_pressMenuRight!=null)
            m_pressMenuRight.SetOnOff(m_currentState.m_menuRight);
        if(m_previousState.m_menuCenter!=m_currentState.m_menuCenter)
            if(m_pressMenuCenter!=null)
            m_pressMenuCenter.SetOnOff(m_currentState.m_menuCenter);
        if(m_previousState.m_leftTrigger!=m_currentState.m_leftTrigger)
            if(m_leftTrigger!=null)
            m_leftTrigger.SetValue(m_currentState.m_leftTrigger);
        if(m_previousState.m_rightTrigger!=m_currentState.m_rightTrigger)
            if(m_rightTrigger!=null)
            m_rightTrigger.SetValue( m_currentState.m_rightTrigger);
        
        Vector2 left= new Vector2(m_currentState.m_leftStickX,m_currentState.m_leftStickY);
        Vector2 right= new Vector2(m_currentState.m_rightStickX,m_currentState.m_rightStickY);
        if(m_previousState.m_leftStickX!=m_currentState.m_leftStickX || m_previousState.m_leftStickY!=m_currentState.m_leftStickY)
            if(m_leftStick!=null )
            {
                m_leftStick.SetValue(left);
            }

        if(m_previousState.m_rightStickX!=m_currentState.m_rightStickX || m_previousState.m_rightStickY!=m_currentState.m_rightStickY)
            if(m_rightStick!=null )
            {
                m_rightStick.SetValue(right);
            }

        string text = "Use left stick to turn the cube, hold A to change color\n";
        text += string.Format("IsConnected {0}  \n", 
            m_currentState.m_isConnected);
        text += string.Format("\tTriggers {0} {1}\n", 
            m_currentState.m_leftTrigger, m_currentState.m_rightTrigger);
        text += string.Format("\tD-Pad {0} {1} {2} {3}\n", 
            m_currentState.m_arrowUp,m_currentState.m_arrowRight,
            m_currentState.m_arrowDown,m_currentState.m_arrowLeft
            );

        text += string.Format("\tButtons Start {0} Back {1} Guide {2}\n",
            m_currentState.m_start, m_currentState.m_back, m_currentState.m_menuCenter
            );
        text += string.Format("\tButtons LeftStick {0} RightStick {1} LeftShoulder {2} RightShoulder {3}\n", 
             m_currentState.m_leftStick, m_currentState.m_rightStick, m_currentState.m_leftShoulder, m_currentState.m_rightShoulder
            );
        text += string.Format("\tButtons A {0} B {1} X {2} Y {3}\n", 
            m_currentState.m_a, m_currentState.m_b, m_currentState.m_x, m_currentState.m_y
            );
        text += string.Format("\tSticks Left {0} {1} Right {2} {3}\n", 
             m_currentState.m_leftStickX, m_currentState.m_leftStickY, m_currentState.m_rightStickX, m_currentState.m_rightStickY
            );
        m_debugText=text;
        m_onDebugText.Invoke(m_debugText);
        
    }
    [TextArea(2,6)]
    public string m_debugText;
    public UnityEvent<string> m_onDebugText;
}
