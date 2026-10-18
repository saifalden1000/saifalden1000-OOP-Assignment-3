# Part 02 — answers

---

## Reports

- What was the problem?
  The three report exporters duplicated the same steps for loading, validating, formatting, and saving reports.

- What did you change?
  I created an abstract ReportExporter class that contains the shared export workflow. Each exporter inherits from it and implements its own Format() method.

- Why did you choose that approach?
  I chose the Template Method pattern because it keeps the export steps and their order in one place while allowing each exporter to customize the formatting. An abstract class provides both shared implementation and an abstract method that derived classes must implement.

---

## Enrollment

- What was the problem?
  Program.cs created and called PaymentGateway, SeatInventory, InvoiceGenerator, and EmailService directly. This made the caller responsible for coordinating the enrollment workflow and knowing the correct order of operations.

- What did you change?
  I introduced an EnrollmentFacade that coordinates the four services and provides one method to enroll a student. Program.cs now uses the facade instead of calling the services individually.

- Why did you choose that approach?
  I chose the Facade pattern because it hides the complexity of the enrollment workflow behind a simple interface. The caller no longer needs to know which services are involved or the order in which they must be called.