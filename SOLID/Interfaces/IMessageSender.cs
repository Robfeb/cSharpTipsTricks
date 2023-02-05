namespace SOLID
{
    interface IMessageSender
    {
        int SendConfirmationMessage(string message);

        // are we sure if ReadReceipt is supported for all implementors?
        bool GetReadReceipt(int messageId);
    }
}