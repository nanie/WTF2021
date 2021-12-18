using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trubisko.Input
{
    public interface IInputModule
    {
        void UpdateValues();
        Dictionary<string, float> GetInputValues();
    }
}
