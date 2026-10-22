//numero 7
//Par o impar Indirecta
/*Determinar si un numero es par o impar
objetvo;determina si un numero entero no negativo es par o impar, ¿como funciona?
EsPar() llama a EsImpar(), EsImpar() llama a EsPar(),   el proceso determina cuano el numero llega a cero*/


using System;
class Program
{
    static bool EsPar(int n)
    {
        if (n == 0)
            return true;
        return EsImpar(n - 1);
    }
    static bool EsImpar(int n)
    {
        if (n == 0)
            return false;
        return EsPar(n - 1);
    }
    static void Main()
    {
        Console.Write("ingresar un numero:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 100000.");
            return;
        }
        if (EsPar(n))
            Console.WriteLine("El numero es par.");
        else
            Console.WriteLine("El numero es impar.");
    }
}
