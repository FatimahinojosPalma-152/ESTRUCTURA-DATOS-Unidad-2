//numero 5
//Invertir un numero(Directa)
//invertir el orden de los digitos de un numero entero positivo mediante llamadas recursividad 


using System;

class Program
{
    static long invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;

        return invertir(n / 10, resultado * 10 + n % 10);
    }

    static void Main()
    {
        Console.Write("ingrese un numero positivo: ");
        long n = long.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("el numero debe de ser positivo.");
            return;
        }

        Console.WriteLine("numero invertido: " + invertir(n));
    }
}
