# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
  The class violated the Open/Closed Principle because adding a new carrier required modifying the switch statement.

- What did you change?
  I introduced the IShippingCarrier interface and separate carrier classes. ShippingCostCalculator now uses dependency injection and a dictionary to find the correct carrier.

---

## OrderProcessor

- What was the problem?
  OrderProcessor created SqlOrderRepository and SmtpEmailSender directly, making it tightly coupled to their implementations.

- What did you change?
  I introduced IOrderRepository and IEmailSender interfaces and injected their implementations through the constructor. OrderProcessor now depends on abstractions instead of concrete classes.

---

## Notifications

- What was the problem?
  The inheritance hierarchy grew for every combination of notification channel, urgency, and scheduling.

- What did you change?
  I used composition by introducing INotificationChannel and a Notification class that accepts a channel through its constructor. Urgency and scheduling are configured independently, and separate channel classes handle email, SMS, and push notifications.

---

## Proof

- New carrier file(s): ShippingCarriers.cs (UPSShippingCarrier)
- New notification channel file(s): Notifications.cs (PushNotificationChannel)
- Existing classes left unchanged? Yes, when adding a new carrier or notification channel after the refactoring, the existing calculator and notification abstractions do not need modification. Program.cs is updated to register and use the new implementations.