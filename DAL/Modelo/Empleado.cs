using System;
using System.Collections.Generic;

namespace DAL.Modelo
{
    public partial class Empleado
    {

        public int Id { get; set; }
        public string NombreEmpleado { get; set; } = null!;
        public int? NivelAccId { get; set; }
        public string? Apellidos { get; set; }

        public virtual NivelAcceso? NivelAcc { get; set; }

        public Empleado(int id, string nombreEmpleado)
        {
            this.Id = id;
            this.NombreEmpleado = nombreEmpleado;
 
        }

    
    }
}
