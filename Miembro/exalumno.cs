using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembro
{
    internal class exalumno
    {
        internal class ExAlumno : Miembrodecomunidad
        {
            public string id { get; set; }

            public override void Gruardar()
            {
                throw new System.NotImplementedException();
            }

            public override void Obtener()
            {
                Console.WriteLine("Registrado");
            }
        }
    }
}
