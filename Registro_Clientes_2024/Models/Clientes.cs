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
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Celular { get;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Rnc { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Email { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Direccion { get; set;}

        //ClienteId, Nombres, Telefono, Celular, Rnc, Email, Direccion
    }
}
