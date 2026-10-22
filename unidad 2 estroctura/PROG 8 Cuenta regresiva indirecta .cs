//numero 8
//Cuenta regresiva alternada indirecta 
/*cuenta regresiva alternando dos metodos;mostrar una cuenta regresiva desde un numero hasta cero utilizando dos metodos que se llaman entre si.
¿como funciona?
CuentaA() imprime y llama a CuentaB(), CuentaB() imprime y llama a CuentaA()
el proceso termina cuando el numero es menor que cero.
*/


using System;
class Program
{
    static void CuentaA(int n)
    {
        if (n < 0)
            return;
        Console.WriteLine("A:" + n);
        CuentaB(n - 1);
    }
    static void CuentaB(int n)
    {
        if (n < 0)
            return;
        Console.WriteLine("B:" + n);
        CuentaA(n - 1);
    }
    static void Main()
    {
        Console.Write("ingresar el numero inicial:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingresar un numero entre 0 y 1000.");
            return;
        }
        CuentaA(n);
    }
}
