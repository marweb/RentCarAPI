using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor ingrese Agencia")]
        [StringLength(65, ErrorMessage = "El Campo Agencia no puede ser mayor a 65 caracteres.")]
        public string Agencia { get; set; }
        [Required(ErrorMessage = "Favor ingrese Fecha de Inicio")]
        public DateTime FechaInicioAlquiler { get; set; }
        [Required(ErrorMessage = "Favor ingrese Fecha de Fin")]
        public DateTime FechaFinAlquiler { get; set; }
        public int Status { get; set; }
        [Required(ErrorMessage = "Favor ingrese Creado Por")]
        [StringLength(50, ErrorMessage = "El Campo Creado Por no puede ser mayor a 65 caracteres.")]
        public string CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Favor ingrese ID del Auto")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [Required(ErrorMessage = "Favor ingrese ID del Usuario")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
