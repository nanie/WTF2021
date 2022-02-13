using System;
using Trubisko.Input;
using UnityMVC;
using WTF.PlayerInput;

namespace UnityMVC.Events
{
    public partial class WTFPlayerControllerEvents : MVCEvents
    {
        public Action<UnityMVC.Controller.Controller> onControllerInitialized;
        public Action<UnityMVC.Controller.Controller> onControllerDestroyed;
    }
}

namespace WTF.Player
{
    public partial class WTFPlayerController
    {
        WTFPlayerInputController _playerInputController;
        protected override void SolveDependencies()
        {
            _playerInputController = MVCApplication.Controllers.Get<WTFPlayerInputController>();
        }
        
        protected override void RegisterEvents()
        {
            _playerInputController.Events.onInputDataChanged += PlayerInputChanged;
        }

        protected override void UnregisterEvents()
        {
            _playerInputController.Events.onInputDataChanged -= PlayerInputChanged;
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


        private void PlayerInputChanged(InputData input)
        {
            View.MovePlayer(input);
        }
    }
}