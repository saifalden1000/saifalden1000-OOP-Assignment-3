namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message, DateTime? sendAt);
}

public class EmailNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
            Console.WriteLine($"[email scheduled {sendAt.Value:g}] {to}: {message}");
        else
            Console.WriteLine($"[email] {to}: {message}");
    }
}

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
            Console.WriteLine($"[sms scheduled {sendAt.Value:g}] {to}: {message}");
        else
            Console.WriteLine($"[sms] {to}: {message}");
    }
}

public class PushNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
            Console.WriteLine($"[push scheduled {sendAt.Value:g}] {to}: {message}");
        else
            Console.WriteLine($"[push] {to}: {message}");
    }
}

public class Notification
{
    private readonly INotificationChannel _channel;

    public bool IsUrgent { get; set; }
    public DateTime? SendAt { get; set; }

    public Notification(INotificationChannel channel)
    {
        _channel = channel;
    }

    public void Send(string to, string message)
    {
        if (IsUrgent)
            message = $"[URGENT] {message}";

        _channel.Send(to, message, SendAt);
    }
}