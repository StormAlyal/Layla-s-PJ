using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layla_s_PJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class MiembroDeLaComunidad
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public class Empleado : MiembroDeLaComunidad
        {
            public int NoEmp { get; set; }
            public int Sueldo { get; set; }
        }

        public class Docente : Empleado
        {
            public string Tanda { get; set; }
            
        }

        public class Administrador : Docente
        {
            public string Posicion { get; set; }
        }

        public class Maestro : Docente
        {
            public string Materia { get; set; }
            public int CantidadEstudiantes { get; set; }
        }

        public class Administrativo : Empleado
        {
            public int DocenteSupervision { get; set; }
        }

        public class Estudiante : MiembroDeLaComunidad
        {
            public int Matricula { get; set; }
            public int Curso { get; set; }
        }

        public class ExAlumno : MiembroDeLaComunidad
        {
            public int Matricula { get; set; }
            public DateTime FechaRetiro { get; set; }
        }

        
    }
}
