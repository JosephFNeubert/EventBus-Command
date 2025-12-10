namespace Chapter.Commands
{
    public class TurnLeft : Command
    {
        private BikeController2 _controller;

        public TurnLeft(BikeController2 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController2.Direction.Left);
        }
    }
}