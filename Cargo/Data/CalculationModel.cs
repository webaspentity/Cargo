using System.ComponentModel.DataAnnotations;

namespace Cargo.Data;

public class CalculationModel
{
    public string? CargoCategory { get; set; }
    public decimal? Price { get; set; }

    [Required]
    public float? Weight { get; set; }

    [Required]
    public float? Volume { get; set; }

    [Required]
    [StringLength(10, MinimumLength = 10, ErrorMessage = "Введите 10-значное число.")]
    public string Code { get; set; } = default!;

    public bool Insurance { get; set; }

    public bool CustomsClearance { get; set; }

    public Object? Image { get; set; }
    [Required]
    
    public string? Name { get; set; }
    [Required(ErrorMessage = "Введите номер телефона")]
    public string? Telephone { get; set; }
    [Required]
    public string? Email { get; set; }

    public string? Comment { get; set; }
}
