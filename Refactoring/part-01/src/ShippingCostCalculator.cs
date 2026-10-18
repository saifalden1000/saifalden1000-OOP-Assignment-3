namespace RefactoringLab;

public class ShippingCostCalculator
{
    private readonly Dictionary<string, IShippingCarrier> _carriers;

    public ShippingCostCalculator(IEnumerable<IShippingCarrier> carriers)
    {
        _carriers = new Dictionary<string, IShippingCarrier>();

        foreach (var carrier in carriers)
        {
            _carriers.Add(carrier.Name, carrier);
        }
    }

    public decimal Calculate(string carrier, decimal weightKg)
    {
        if (!_carriers.TryGetValue(carrier, out var shippingCarrier))
        {
            throw new ArgumentException($"Unknown carrier: {carrier}");
        }

        return shippingCarrier.Calculate(weightKg);
    }
}