using UnityEngine;
namespace Player
{
    public class IdleState : State
    {
        // constructor
        public IdleState(PlayerScript player, StateMachine sm) : base(player, sm)
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
            player.CheckForRun();
            Debug.Log("checking for run");
            base.LogicUpdate();
            player.CheckForJump();
            Debug.Log("checking for jump");
            base.LogicUpdate();
            player.CheckForCrouch();
            Debug.Log("checking for crouch");
            base.LogicUpdate();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}