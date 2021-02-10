using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rentcar.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor ingrese nombre")]
        [StringLength(100, ErrorMessage = "El Campo Nombre no puede ser mayor a 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Favor ingrese Marca")]
        [StringLength(25, ErrorMessage = "El Campo Marca no puede ser mayor a 25 caracteres.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Favor ingrese Color")]
        [StringLength(25, ErrorMessage = "El Campo Color no puede ser mayor a 25 caracteres.")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Favor ingrese Cantidad de Stock")]
        public int Stock { get; set; }
        public int Status { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
