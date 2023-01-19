using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data
{
    public class DBDatosContext : DbContext
    {
        public DBDatosContext() : base("KeyDB")
        {

        }
        //Propiedades DBSET

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
