namespace DesignPatterns
{
    class Client
    {
        public void StartProcess()
        {
            this.CreateProcess().DoWork();
        }

        protected virtual IProcess CreateProcess()
        {
            return new Process();
        }
    }
}