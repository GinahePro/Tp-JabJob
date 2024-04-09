namespace Player
{
    public class PlayerState_OnGround : PlayerState_Base
    {
        public PlayerState_OnGround(PlayerContext context) : base(context)
        {

        }
        public override void CustomUpdate()
        {
            base.CustomUpdate();
        }

        public override void OnEnter()
        {
            _context.rb.drag = _context.playerBodysettings.groundDrag;
            _context.controller.Jump.AddListener(Jump);
        }

        public override void OnLeave()
        {
            _context.controller.Jump.RemoveListener(Jump);
        }

        public void Jump()
        {

        }
    }
}
