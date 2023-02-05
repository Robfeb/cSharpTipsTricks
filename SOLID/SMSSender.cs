namespace SOLID
{
    class SMSSender : BetterMessageSender
    {
        SMSSender(string targetNumber): base(targetNumber){}
        public override void SendConfirmationMessage(string message)
        {
            // violates liskov substitution
              if(message.Length > 200) throw new ArgumentException("Message too long");
        }
    }
}