using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Eloi.XInput
{

    public class UI2DMono_XInputOnOffRelay : MonoBehaviour
    {
        public bool m_stateOn;
        public UnityEvent<bool> m_onOnOffChanged;
        public GameObject[] m_setObjectOnOff;

        public void SetOnOff(bool isOn)
        {
            m_stateOn = isOn;
            for (int i = 0; i < m_setObjectOnOff.Length; i++)
            {
                if (m_setObjectOnOff[i])
                    m_setObjectOnOff[i].SetActive(isOn);
            }
            m_onOnOffChanged.Invoke(isOn);
        }

    }
}
