public delegate void NotificationHandler(string message);
// public delegate void BookIssueHandler(object? sender, BookIssuedEventArgs e);
public class NotificationService
{
    public event NotificationHandler Onnotify;
    public void SendemailNotification(string message)
    {
        Console.WriteLine($"Email sent to  with messag: {message}");
    }
    public static void SendSmsNotification(string message)
    {
        Console.WriteLine($"Sending sms to {message}");
    }
    public void Notify(string message)
    {
        Onnotify?.Invoke(message);
    }
   
}