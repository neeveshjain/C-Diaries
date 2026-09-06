using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

interface CreateNotificationSystem
{
    public void Send();
}

class EmailNotification : CreateNotificationSystem
{
    public void Send()
    {
        System.Console.WriteLine("Send Email Notification");
    }
}

class SmsNotification : CreateNotificationSystem
{
    public void Send()
    {
        System.Console.WriteLine("Send SMS Notification");
    }
}
class PushNotification : CreateNotificationSystem
{
    public void Send()
    {
        System.Console.WriteLine("Send Push Notification");
    }
}

class NotificationFactory
{
    public CreateNotificationSystem returnNotificationFactory(string type)
    {
        if(type == "email")
        {
            return new EmailNotification();
        }
        else if (type == "sms")
        {
            return new SmsNotification();
        }
        else
        {
            return new PushNotification();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        NotificationFactory notificationFactory = new NotificationFactory();
        CreateNotificationSystem n =  notificationFactory.returnNotificationFactory("email");

    }
}