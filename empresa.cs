using EspacioEmpresa;

namespace EspacioEmpresa
{
    public class empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIng
        private double sueldoBasico;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        public int Antiguedad()
        {
            Antiguedad = DateTime.Now.Year - FechaIng.Year;
        }


    }
}
public public enum cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

empleado nuevoEmpleado = empleado();

int Antiguedad = empleado.Antiguedad;

Console.WriteLine("La antiguedad es : " +Antiguedad);