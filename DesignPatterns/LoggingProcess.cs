namespace DesignPatterns
{
    class LoggingProcess : IProcess
    {
        readonly IProcess process;
        public LoggingProcess(IProcess process) => this.process = process;


        public void DoWork()
        {
            Console.WriteLine("before dowork");
            this.process.DoWork();
            Console.WriteLine("after dowork");
        }
    }
}