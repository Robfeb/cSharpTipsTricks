using System;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Toyota();
            toyota.Accelerate();
            toyota.Run();

            Car ferrari = new Ferrari();
            ferrari.Accelerate();

            ferrari.Run();
            ferrari.Stop();
            Ferrari realFerrari = (Ferrari)ferrari;
            realFerrari.Stop();
        }
    }
}
