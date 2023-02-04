using System;

namespace Equality
{

    class Program
    {
        static void Main(string[] args)
        {
            EntityExample entity = new EntityExample(1);
            Console.WriteLine($"is Equal {entity.Equals(1)}");
        }
    }
}
