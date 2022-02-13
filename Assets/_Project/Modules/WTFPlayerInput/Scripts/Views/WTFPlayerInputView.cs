using System;
using Trubisko.Input;

namespace UnityMVC.Events
{
    public partial class WTFPlayerInputControllerEvents
    {
        public Action<View.View> onViewEnabled;
        public Action<View.View> onViewDisabled;
        public Action<View.View> onViewDestroyed;
    }
}

namespace UnityMVC.Model
{
    public class WTFPlayerInputViewModel : MVCModel
    {
        internal InputData _inputData = new InputData();
    }
}

namespace WTF.PlayerInput
{
    public partial class WTFPlayerInputView
    {
        WTFPlayerInputMVCComponent component;

        protected override void SolveDependencies()
        {
            component = GetMVCComponent<WTFPlayerInputMVCComponent>();
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
            component.UpdateData(ref Data._inputData);
            Events.onInputDataChanged?.Invoke(Data._inputData);
        }
    }
}