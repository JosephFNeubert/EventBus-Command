namespace Chapter.Commands
{
    public class TurnRight : Command
    {
        private BikeController2 _controller;

        public TurnRight(BikeController2 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController2.Direction.Right);
        }
    }
}