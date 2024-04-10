namespace Player
{
    public class PlayerState_InAir : PlayerState_Base
    {
        public PlayerState_InAir(PlayerContext context) : base(context)
        {

        }
        public override void CustomUpdate()
        {
            base.CustomUpdate();
        }

        public override void OnEnter()
        {
            _context.rb.drag = _context.playerBodyConst.AirDrag;
        }

        public override void OnLeave()
        {

        }
    }
}
