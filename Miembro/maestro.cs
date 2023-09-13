using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Miembro.docente;

namespace Miembro
{
    internal class maestro
    {
        public class Maestro : Docente
        {
            public string Clase { get; set; }
            public string Horario { get; set; }
        }
    }
}
