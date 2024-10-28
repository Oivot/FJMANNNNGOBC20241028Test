using System.ComponentModel.DataAnnotations;

namespace CRM.DTOs.CustomerDTO
{
    public class CreateCustomerDTO
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener mas de 50 caracteres")]
        public string Name {  get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de 50 caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(255, ErrorMessage = "El campo {0} no puede tener mas de 255 caracteres")]
        public string? Address { get; set; }
    }
}
