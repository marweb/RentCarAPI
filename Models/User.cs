using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor ingrese nombre")]
        [StringLength(100, ErrorMessage = "El Campo Nombre no puede ser mayor a 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Favor ingrese email")]
        [EmailAddress]
        [StringLength(75, ErrorMessage = "El Campo Email no puede ser mayor a 75 caracteres.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Favor ingrese Telefono")]
        [Phone]
        [StringLength(20,ErrorMessage = "El Campo Telefono no puede ser mayor a 75 caracteres.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Favor ingrese Direccion")]
        [StringLength(120, ErrorMessage = "El Campo Direccion no puede ser mayor a 75 caracteres.")]
        public string Direccion { get; set; }
        public int Status { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
