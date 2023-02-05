namespace SOLID
{
    class Order
    {
        //Violates Single Responsiblity Principle
        //Also violates Dependency Inversion
        public void SendConfirmationMessage(string message) 
        { 
            //send email
        }
    }
}