namespace Virtual
{
    public class Toyota : Car
    {
        public override void Run()
            => Console.WriteLine($"Toyota running at speed:{this.speed}" );
        
    }
}
