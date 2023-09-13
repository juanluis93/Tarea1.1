using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembro
{
    internal class Class1
    {
        public class Empleado : Miembrodecomunidad
        {
            public string Codigo { get; set; }
            public string Despartamento { get; set; }
            public string Posicion { get; set; }

            public override void Gruardar()
            {
                throw new NotImplementedException();
            }

            public override void Obtener()
            {
                Console.WriteLine("REGISTRADO");


            }
        }
    }
}
