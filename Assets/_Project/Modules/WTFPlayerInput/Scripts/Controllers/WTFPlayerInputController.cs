using System;
using Trubisko.Input;

namespace UnityMVC.Events
{
    public partial class WTFPlayerInputControllerEvents : MVCEvents
    {
        public Action<UnityMVC.Controller.Controller> onControllerInitialized;
        public Action<UnityMVC.Controller.Controller> onControllerDestroyed;

        public Action<InputData> onInputDataChanged;
    }
}

namespace WTF.PlayerInput
{
    public partial class WTFPlayerInputController
    {
        // MVC properties available: View and Events

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
    }
}