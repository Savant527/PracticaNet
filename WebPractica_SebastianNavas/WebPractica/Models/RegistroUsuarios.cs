using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WebPractica.Models
{
    public class RegistroUsuarios
    {
        [Required(ErrorMessage = "Nombre requerido")]
        [Display(Name = "Nombre del usuario")]
        [DataType(DataType.Text)]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "Documento requerido")]
        [Display(Name = "No. Documento")]
        [DataType(DataType.Text)]

        public string Documento { get; set; }

        [Required(ErrorMessage = "Email")]
        [EmailAddress]

        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(15,ErrorMessage ="La {0} debe estar entre al menos {2} carácteres de longitud",MinimumLength =5)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]

        public string Password { get; set; }


        //[Required(ErrorMessage = "La confirmación de la contraseña es requerida")]
        //[Compare("Password", ErrorMessage = "La {0} debe estar entre al menos {2} carácteres de longitud")]
        //[Display(Name = "Confirmar contraseña")]
        //[DataType(DataType.Password)]

        //public string ConfirPassword { get; set; }
    }
}
