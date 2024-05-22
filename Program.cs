using EspacioCalculadora;
using EspacioEmpresa;

Calculadora calculadora = new Calculadora();

int operacion;

do
{
    double resultado = calculadora.resultado;
    Console.WriteLine("Valor de resultado actual : " + resultado);
    Console.WriteLine("Ingrese un numero para realizar una operacion");
    Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividr\n5-Limpiar\n6-Finalizar");
    operacion = Convert.ToInt16(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            Console.WriteLine("Ingrese el valor a sumar:");
            double valorSumar = Convert.ToDouble(Console.ReadLine());
            calculadora.Sumar(valorSumar);
            break;
        case 2:
            Console.WriteLine("Ingrese el valor a restar:");
            double valorRestar = Convert.ToDouble(Console.ReadLine());
            calculadora.Restar(valorRestar);
            break;
        case 3:
            Console.WriteLine("Ingrese el valor a multiplicar:");
            double valorMultiplicar = Convert.ToDouble(Console.ReadLine());
            calculadora.Multiplicar(valorMultiplicar);
            break;
        case 4:
            Console.WriteLine("Ingrese el valor a dividir:");
            double valorDividir = Convert.ToDouble(Console.ReadLine());
            calculadora.Dividir(valorDividir);
            break;
        case 5:
            calculadora.Limpiar();
            break;
        case 6:
            operacion = 6;
            Console.WriteLine("Fin del programa.");
            break;
        default:
            Console.WriteLine("Por favor, seleccione una opción válida.");
            break;
    }


} while (operacion != 6);

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Aureliano", "Buendia", new DateTime(1998, 10, 19), 'S', new DateTime(2019, 7, 24), 650000, Cargos.Investigador);
empleados[1] = new Empleado("Elisa Beatriz", "Bachofen", new DateTime(1976, 11, 19), 'C', new DateTime(1997, 9, 14), 900000, Cargos.Ingeniera);
empleados[2] = new Empleado("Nana", "Osaki", new DateTime(1981, 3, 5), 'C', new DateTime(2001, 12, 17), 777777, Cargos.Especialista);

// Escribe los datos de los 3 empleados, lo use para chequear si se cargaban los datos correctamente
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









