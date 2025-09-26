using UnityEngine;
namespace Player
{
    public class JumpState : State
    {
        // constructor
        public JumpState(PlayerScript player, StateMachine sm) : base(player, sm)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            player.CheckForIdle();
            Debug.Log("checking for idle");
            base.LogicUpdate();
            player.CheckForRun();
            Debug.Log("checking for run");
            base.LogicUpdate();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}