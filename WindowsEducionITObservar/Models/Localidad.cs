using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public List<Profesor> profesores { get; set; }
        public List<Estudiante> estudiantes { get; set; }
    }
}
