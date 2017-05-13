using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class RegistroSpare
    {
        [Key]

        [Required(ErrorMessage ="Datos Obligatorio")]
        public int SpareID { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string NumeroParte{ get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string SerialNumero { get; set; }

        [Required(ErrorMessage = "Datos Obligatorio")]
        public string Almacen { get; set; }

        public DateTime Fecha { get; set; }


    }
}