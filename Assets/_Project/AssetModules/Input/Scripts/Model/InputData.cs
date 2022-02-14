using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trubisko.Input
{
    public class InputData
    {
        public float HorizontalAxis {get; set;}
        public float VerticalAxis { get; set; }
        public bool ButtonSkill1 { get; set; }
        public bool ButtonSkill2 { get; set; }
        public bool Jump { get; set; }
        public float mouseDeltaX { get; set; }
        public float mouseDeltaY { get; set; }
    }
}

