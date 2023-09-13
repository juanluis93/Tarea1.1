using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembro
{
    internal class Estudiante

    {
        public class Estudiente : Miembrodecomunidad
        {
            public string MatriculaActiva { get; set; }

            public override void Gruardar()
            {
                throw new System.NotImplementedException();
            }

            public override void Obtener()
            {
                Console.WriteLine("REGISTRADO");

            }
        }
    }
}
