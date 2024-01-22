using System.ComponentModel.DataAnnotations;

namespace Registro_Clientes_2024.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage = "El número de teléfono no puede tener más de 10 dígitos")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El número de teléfono solo puede contener dígitos")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(9, ErrorMessage = "El número de teléfono no puede tener más de 10 dígitos")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El número de teléfono solo puede contener dígitos")]
        public string? Rnc { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Email { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Direccion { get; set;}

        //ClienteId, Nombres, Telefono, Celular, Rnc, Email, Direccion
    }
}
