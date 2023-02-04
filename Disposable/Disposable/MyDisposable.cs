namespace Disposable
{
    class MyDisposable : IDisposable
    {
        MySafeFileHandle handle =
            NativeMethods.CreateFile("somefile", NativeMethods.GENERIC_READ,
                FileShare.Read, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);
        int x = 5;
        public void PrintX() => Console.Write(x);

        public void Dispose()
        {
            handle.Dispose();
        }
    }
}