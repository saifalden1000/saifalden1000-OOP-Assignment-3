using RefactoringLab;

var shipping = new ShippingCostCalculator(new IShippingCarrier[]
{
    new AramexShippingCarrier(),
    new FedExShippingCarrier(),
    new DHLShippingCarrier(),
    new UPSShippingCarrier()
});

Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
Console.WriteLine($"UPS 2kg    → {shipping.Calculate("UPS", 2)}");
Console.WriteLine();

var processor = new OrderProcessor(
    new SqlOrderRepository(),
    new SmtpEmailSender());

processor.Process(1001, "customer@example.com");
Console.WriteLine();

new Notification(new EmailNotificationChannel())
{
    IsUrgent = true,
    SendAt = DateTime.Today.AddHours(18)
}.Send("customer@example.com", "Your order ships tomorrow");

new Notification(new SmsNotificationChannel())
{
    IsUrgent = true
}.Send("+201000000000", "OTP 4821");

new Notification(new PushNotificationChannel())
{
    IsUrgent = true,
    SendAt = DateTime.Today.AddHours(19)
}.Send("customer-1001", "Your order is ready");