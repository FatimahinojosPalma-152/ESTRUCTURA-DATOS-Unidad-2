// numero 6
//Suma de digitos(directa)
//Sumar todos los digitos de un numero entero positivo
/*como funciona?
 El metodo SumarDigitos() suma el ultimo digito con el resultado de llevarse a si mismo  de la función aplicada al número sin ese dígito.*/



using System;
class Program
{
    static int SumarDigito(int n)
    {
        if (n == 0)
            return 0;
        return n % 10 + SumarDigito(n / 10);
    }
    static void Main()
    {
        Console.Write("ingresar un numero:");
        int n=int.Parse(Console.ReadLine());
        if(n<0)
        {
            Console.WriteLine("ingresar un numero positivo.");
            return;
        }
        Console.WriteLine("Suma de digito:"+SumarDigito(n));
    }
}
