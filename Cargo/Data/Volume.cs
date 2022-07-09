namespace Cargo.Data;
using System.ComponentModel.DataAnnotations;

public class Volume
{
    [Required]
    public double Width { get; set; }
    [Required]
    public double Height { get; set; }
    [Required]
    public double Length { get; set; }
    [DisplayFormat(DataFormatString = "{0:F2}")]
    public double Value
    {
        get => Width * Height * Length;
    }
}
