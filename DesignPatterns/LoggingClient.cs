namespace DesignPatterns
{
    class LoggingClient : Client
    {

        protected override IProcess CreateProcess()
        {
            return new LoggingProcess(new Process());
        }
    }
}