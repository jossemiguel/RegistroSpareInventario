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

        public int SpareID { get; set; }
        public string Nombre { get; set; }
        public string NumeroParte{ get; set; }
        public string SerialNumero { get; set; }
        public string Almacen { get; set; }
        public DateTime Fecha { get; set; }


    }
}