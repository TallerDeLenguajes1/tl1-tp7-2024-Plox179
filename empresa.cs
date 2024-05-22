using EspacioEmpresa;

namespace EspacioEmpresa
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniera,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        private string nombre = string.Empty;
        private string apellido = string.Empty;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIng;
        private double sueldoBasico;
        private Cargos cargo;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIng, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            EstadoCivil = estadoCivil;
            FechaIng = fechaIng;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }

        public int CalcularAntiguedad()
        {
            DateTime hoy = DateTime.Today;
            int antiguedad = hoy.Year - FechaNac.Year;
            if (FechaIng > hoy.AddYears(-antiguedad)) antiguedad--;
            return antiguedad;
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNac.Year;
            if (FechaNac > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        public int CalcularJubilacion()
        {
            int edadActual = CalcularEdad();
            int jubilacion = 65 - edadActual;
            return jubilacion;
        }

        public double CalcularSalario()
        {
            int antiguedad = CalcularAntiguedad();
            double basico = SueldoBasico;
            char estadoCivil = EstadoCivil;
            double adicional;
            if (antiguedad > 20)
            {
                adicional = basico * 0.25;
            }
            else
            {
                adicional = basico * ((double)antiguedad / 100);
            }
            if (Cargo == Cargos.Ingeniera || Cargo == Cargos.Investigador)
            {
                adicional *= 1.5;
            }
            if (estadoCivil == 'C')
            {
                adicional += 150000;
            }

            double salario = basico + adicional;

            return salario;

        }




    }
}

partial class Program
{
    public static void Main()
    {
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Aureliano", "Buendia", new DateTime(1998, 10, 19), 'S', new DateTime(2019, 7, 24), 650000, Cargos.Investigador);
        empleados[1] = new Empleado("Elisa Beatriz", "Bachofen", new DateTime(1976, 11, 19), 'C', new DateTime(1997, 9, 14), 900000, Cargos.Ingeniera);
        empleados[2] = new Empleado("Nana", "Osaki", new DateTime(1981, 3, 5), 'C', new DateTime(2001, 12, 17), 777777, Cargos.Especialista);

        Console.WriteLine("Datos de los empleados:");
        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Apellido: {empleado.Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {empleado.FechaNac.ToShortDateString()}");
            Console.WriteLine($"Estado Civil: {empleado.EstadoCivil}");
            Console.WriteLine($"Fecha de Ingreso: {empleado.FechaIng.ToShortDateString()}");
            Console.WriteLine($"Sueldo Básico: {empleado.SueldoBasico:C}");
            Console.WriteLine($"Cargo: {empleado.Cargo}");
            Console.WriteLine();
        }

    }
}

