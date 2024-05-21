using EspacioCalculadora;

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





