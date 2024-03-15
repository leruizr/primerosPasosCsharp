using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una operación matemática:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        // Leer la opción del usuario
        Console.Write("Ingrese el número de la operación deseada: ");
        int opcion = int.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = Suma();
                break;
            case 2:
                resultado = Resta();
                break;
            case 3:
                resultado = Multiplicacion();
                break;
            case 4:
                resultado = Division();
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }

        Console.WriteLine("El resultado es: " + resultado);
    }

    static double Suma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        return num1 + num2;
    }

    static double Resta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        return num1 - num2;
    }

    static double Multiplicacion()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        return num1 * num2;
    }

    static double Division()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Error: no se puede dividir por cero");
            return 0;
        }

        return num1 / num2;
    }
}
