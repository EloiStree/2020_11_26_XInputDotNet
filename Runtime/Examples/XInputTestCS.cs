using UnityEngine;
using XInputDotNetPure; // Required in C#
namespace Eloi.XInput
{

    public class XInputTestCS : MonoBehaviour
    {
        bool playerIndexSet = false;
        PlayerIndex playerIndex;
        GamePadState state;
        GamePadState prevState;

        // Use this for initialization
        void Start()
        {
            // No need to initialize anything for the plugin
        }

        void FixedUpdate()
        {
            // SetVibration should be sent in a slower rate.
            // Set vibration according to triggers
            GamePad.SetVibration(playerIndex, state.Triggers.Left, state.Triggers.Right);
        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnGUI()
        {
            string text = "Use left stick to turn the cube, hold A to change color\n";
            text += string.Format("IsConnected {0} Packet #{1}\n", state.IsConnected, state.PacketNumber);
            text += string.Format("\tTriggers {0} {1}\n", state.Triggers.Left, state.Triggers.Right);
            text += string.Format("\tD-Pad {0} {1} {2} {3}\n", state.DPad.Up, state.DPad.Right, state.DPad.Down, state.DPad.Left);
            text += string.Format("\tButtons Start {0} Back {1} Guide {2}\n", state.Buttons.Start, state.Buttons.Back, state.Buttons.Guide);
            text += string.Format("\tButtons LeftStick {0} RightStick {1} LeftShoulder {2} RightShoulder {3}\n", state.Buttons.LeftStick, state.Buttons.RightStick, state.Buttons.LeftShoulder, state.Buttons.RightShoulder);
            text += string.Format("\tButtons A {0} B {1} X {2} Y {3}\n", state.Buttons.A, state.Buttons.B, state.Buttons.X, state.Buttons.Y);
            text += string.Format("\tSticks Left {0} {1} Right {2} {3}\n", state.ThumbSticks.Left.X, state.ThumbSticks.Left.Y, state.ThumbSticks.Right.X, state.ThumbSticks.Right.Y);
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), text);
        }
    }
}