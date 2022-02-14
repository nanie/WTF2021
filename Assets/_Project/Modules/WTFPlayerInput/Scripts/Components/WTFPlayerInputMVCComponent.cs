using Trubisko.Input;
using UnityEngine;

namespace UnityMVC.Events
{
    public partial class WTFPlayerInputControllerEvents
    {
    }
}

namespace WTF.PlayerInput
{
    public partial class WTFPlayerInputMVCComponent
    {
        protected override void SolveDependencies()
        {
        }
        
        protected override void RegisterEvents()
        {
        }
        
        protected override void UnregisterEvents()
        {
        }
        
        protected override void MVCAwake()
        {
        }

        protected override void MVCStart()
        {
        }

        protected override void MVCLateStart()
        {
        }

        protected override void MVCUpdate()
        {
        }

        internal void UpdateData(ref InputData inputData)
        {
            inputData.HorizontalAxis = Input.GetAxis("Horizontal");
            inputData.VerticalAxis = Input.GetAxis("Vertical");
            inputData.ButtonSkill1 = Input.GetMouseButton(0);
            inputData.ButtonSkill2 = Input.GetMouseButton(1);
            inputData.Jump = Input.GetButton("Jump");
            inputData.mouseDeltaX = Input.GetAxis("Mouse X");
            inputData.mouseDeltaY = Input.GetAxis("Mouse Y");
        }
    }
}