//numero 9
//Suma mediante dos metodos(indirecta)
//suma de numeros mediante recursividad indirecta 
/*Calcular la suma de los numeros del 1 hasta n utilizando dos metodos que se llaman mutuamente*/


using System;
class Program
{
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaB(n - 1);
    }
    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        return SumaA(n - 1);
    }
    static void Main()
    {
        Console.Write("INGRESE UN NUMERO:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("ingresar un numero ente 0 y 100000.");
            return;
        }
        Console.WriteLine("La suma es:" + SumaA(n));
    }
}
