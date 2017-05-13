using SistemaInventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaInventario.DAL
{
    public class InventarioDB: DbContext
    {
        public InventarioDB(): base ("ConStr")
        {

        }
        public virtual DbSet <RegistroSpare> Spare { get; set; }
    }
}