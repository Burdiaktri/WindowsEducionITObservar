using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evalaciones { get; set;}
    }
}
