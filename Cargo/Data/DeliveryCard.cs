namespace Cargo.Data;

public class DeliveryCard
{
    public string? Image { get; set; }
    public decimal Price { get; set; }
    public string? Title { get; set; }
    public string? Period { get; set; }
    public double Weight { get; set; }
    public string? Pricing { get => $"от {Price}$/кг"; }
}
