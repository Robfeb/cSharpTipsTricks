namespace SOLID
{
    interface IBetterMessageSenderWithReceipt : IBetterMessageSender
    {
          bool GetReadReceipt(int messageId);
    }
}