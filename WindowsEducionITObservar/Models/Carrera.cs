using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Carrera
    {
        public int CarreraId { get; set; }
        public string Nombre { get; set; }

        public List<Planilla> planillas { get; set; }
    }
}
