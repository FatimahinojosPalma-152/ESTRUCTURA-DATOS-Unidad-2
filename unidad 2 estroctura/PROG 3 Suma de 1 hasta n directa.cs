//numero 3
//Suma de 1 hasta n (Directa)
/*Suma todos los numeros enteros de forma consecutiva desde el 1 hasta el valor n
 ingresado por el usuario usando recursividad*/


using System;
class Program
{
    static int Suma(int n)
    {
        if (n <= 0)
            return 0;
        return n + Suma(n - 1);
    }
    static void Main()
    {
        Console.Write("ingresar un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("ingresar un numero entre 0 y 10000.");
            return;
        }
        Console.WriteLine("la suma es:" + Suma(n));
    }
}



