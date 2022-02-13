using System;
using Trubisko.Input;

namespace UnityMVC.Events
{
    public partial class WTFPlayerControllerEvents
    {
        public Action<View.View> onViewEnabled;
        public Action<View.View> onViewDisabled;
        public Action<View.View> onViewDestroyed;
    }
}

namespace UnityMVC.Model
{
    public class WTFPlayerViewModel : MVCModel
    {
    }
}

namespace WTF.Player
{
    public partial class WTFPlayerView
    {
        WTFPlayerMVCComponent _playerComponent;

        protected override void SolveDependencies()
        {
            _playerComponent = GetMVCComponent<WTFPlayerMVCComponent>();
        }
        
        protected override void RegisterControllerEvents()
        {
        }

        protected override void UnregisterControllerEvents()
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

        public void MovePlayer(InputData input)
        {
            _playerComponent.MovePlayer(input);
        }
    }
}