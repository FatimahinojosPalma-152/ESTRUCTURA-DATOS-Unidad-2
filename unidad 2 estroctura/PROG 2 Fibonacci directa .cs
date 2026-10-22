//numero 2
//Fibonacci(Directa)
/*Optener el numero correspondiente a una posicion especifica(del 0 al 40)
  dentro de la serie de Fibonacci sumando los dos valores anteriores*/


using System;

class Program
{
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("ingresar una posicion:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 40)
        {
            Console.WriteLine("ingresar un numero entero 0 y 40.");
            return;
        }

        Console.WriteLine("Fibonacci:" + Fibonacci(n));
    }
}

