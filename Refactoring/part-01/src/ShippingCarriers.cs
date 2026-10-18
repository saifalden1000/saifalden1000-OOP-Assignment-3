namespace RefactoringLab;

public class AramexShippingCarrier : IShippingCarrier
{
    public string Name => "Aramex";

    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedExShippingCarrier : IShippingCarrier
{
    public string Name => "FedEx";

    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DHLShippingCarrier : IShippingCarrier
{
    public string Name => "DHL";

    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 18m;
    }
}

public class UPSShippingCarrier : IShippingCarrier
{
    public string Name => "UPS";

    public decimal Calculate(decimal weightKg)
    {
        return weightKg * 20m;
    }
}