using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPractica.Models
{
    public class Registros
    {
        [Key]
        public int IdRegistro { get; set; }
        [DisplayName("Foto")]
        public Byte[] Imagen { get; set; }
        [DisplayName("Documento")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName ="varchar(20)")]
        public string Documento { get; set; }
        [DisplayName("Nombre")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [DisplayName("Apellidos")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Apellidos { get; set; }
        [DisplayName("Fecha Nacimiento")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Fecha requerida")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public DateTime FechaNac { get; set; }
        [DisplayName("Dirección")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(100)")]
        public string Direccion { get; set; }
        [DisplayName("Celular")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(15)")]
        public string Celular { get; set; }
        [DisplayName("Género")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(1)")]
        public string Genero { get; set; }
        [DisplayName("Deporte")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Deporte { get; set; }
        [DisplayName("Trabaja")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(2)")]
        public string Trabaja { get; set; }
        [DisplayName("Salario")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Dato requerido")]
  
        public decimal Sueldo { get; set; }
        [DisplayName("Estado")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(1)")]
        public string Estado { get; set; }
    }
}
