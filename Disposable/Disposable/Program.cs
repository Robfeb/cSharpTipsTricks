namespace Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDisposable disposable;
            using (disposable = new MyDisposable())
            {

            }
            disposable.PrintX();
        }
    }

}