namespace Virtual
{
    public class Ferrari : Car
    {
        public override sealed void Run()
            => Console.WriteLine($"Ferrari running at speed:{this.speed}");

        public override void Accelerate()
            => this.speed += 50;
        

        public new void Stop()
            => Console.WriteLine("Stopping ferrari");
    }
}
