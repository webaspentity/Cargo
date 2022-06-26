using System.ComponentModel.DataAnnotations;

namespace Cargo.Data;

public class RequestModel
{
    [Required(ErrorMessage = "Введите имя.")]
    [MaxLength(15, ErrorMessage = "Максимум 15 символов.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Введите номер телефона.")]
    public string? Telephone { get; set; }

    public string? Email { get; set; }

    public string? Question { get; set; }
}
