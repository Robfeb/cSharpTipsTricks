namespace SOLID
{
    class BetterMessageSender
    {
        public BetterMessageSender(string targetAddress) => this.targetAddress = targetAddress;
        protected readonly string targetAddress;

        //Probably should be virtual or abstract
        public virtual void SendConfirmationMessage(string message) 
        { 
            if(message.Length > 500) throw new ArgumentException("Message too long");
            //send email
        }
    }
}