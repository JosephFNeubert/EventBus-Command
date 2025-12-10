namespace Chapter.Commands
{
    public class ToggleTurbo : Command
    {
        private BikeController2 _controller;

        public ToggleTurbo(BikeController2 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}