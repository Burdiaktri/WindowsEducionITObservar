using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

        [ForeignKey("LocalidadId")]
        public Localidad Localidad { get; set; }
        public List<Evaluacion> Evalaciones { get; set;}
    }
}
