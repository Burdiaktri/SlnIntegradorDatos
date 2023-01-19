using Datos.Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacMedico
    {
        private static DBDatosContext context = new DBDatosContext();
        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }

        public static Medico SelectByEspecialidad(string especialidad)
        {
           return context.Medicos.Find(especialidad);
        }

        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }
        public static int Eliminar(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.Id);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
        public static int Update(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.Id);
            medicoOrigen.Nombre = medico.Nombre;

            return context.SaveChanges();
        }

    }
}
