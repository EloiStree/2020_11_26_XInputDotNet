using UnityEngine;
using XInputDotNetPure;
namespace Eloi.XInput
{

    public class XInputMono_FourDoubleJoysticks : MonoBehaviour
    {


        public GamepadJoystickStateToEvent[] m_gamepadJoystickStateToEvent = new GamepadJoystickStateToEvent[4] {

            new GamepadJoystickStateToEvent(PlayerIndex.One),
            new GamepadJoystickStateToEvent(PlayerIndex.Two),
            new GamepadJoystickStateToEvent(PlayerIndex.Three),
            new GamepadJoystickStateToEvent(PlayerIndex.Four)
        };

        void Update()
        {
            FetchAndPushFourControllers();
        }

        private void FetchAndPushFourControllers()
        {
            foreach (GamepadJoystickStateToEvent joysticks in m_gamepadJoystickStateToEvent)
            { joysticks.FetchAndPushChangeInputInfo(); }
        }
    }
}