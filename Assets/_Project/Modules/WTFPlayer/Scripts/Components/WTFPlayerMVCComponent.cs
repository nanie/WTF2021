using Trubisko.Input;
using UnityEngine;

namespace UnityMVC.Events
{
    public partial class WTFPlayerControllerEvents
    {
    }
}

namespace WTF.Player
{
    public partial class WTFPlayerMVCComponent
    {
        [SerializeField] private PlayerMovement _playerMovement;

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

        public void MovePlayer(InputData input)
        {
            _playerMovement.MovePlayer(input.HorizontalAxis, input.VerticalAxis, input.Jump);
        }

    }
}