//numero 1
//Factorial(Directa)
/*Calcular de forma recursiva el factorial de un numero entero entre (0 y 20)
 multiplicando el numero por el factorial de su numero anterior*/


using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("ingrese un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("ingresar un numero entero 0 y 20.");
            return;
        }

        Console.WriteLine("Factorial:" + Factorial(n));
    }
}





