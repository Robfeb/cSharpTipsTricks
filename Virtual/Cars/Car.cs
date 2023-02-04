namespace Virtual
{
    public abstract class Car 
    {
        protected int speed;
        public abstract void Run();
        public virtual void Accelerate() 
            => this.speed += 10;
        public void Stop() 
            => Console.WriteLine("Stopping the car");
    }
}
