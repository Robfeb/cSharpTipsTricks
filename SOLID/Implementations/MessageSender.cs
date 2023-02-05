namespace SOLID
{
    class MessageSender
    {
        public MessageSender(string targetAddress) => this.TargetAddress = targetAddress;
        //Should be hidden
        public string TargetAddress;

        //Probably should be virtual or abstract
        public void SendConfirmationMessage(string message) 
        { 
           
            //send email
        }
    }
}