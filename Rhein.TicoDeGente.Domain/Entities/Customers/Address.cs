using System.ComponentModel.DataAnnotations;

namespace Rhein.TicoDeGente.Domain.Entities.Customers;

public class Address
{
    [Required(ErrorMessage = "A rua é obrigatória.")]
    public string Street { get; set; }

    [Required(ErrorMessage = "O número é obrigatório.")]
    public string Number { get; set; }

    public string? Complement { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório.")]
    public string Neighborhood { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    public string City { get; set; }

    [Required(ErrorMessage = "O estado é obrigatório.")]
    public string State { get; set; }

    [Required(ErrorMessage = "O CEP é obrigatório.")]
    public string ZipCode { get; set; }
}
