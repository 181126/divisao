using System;
class poo
{
    static void Main(string[] args)
    {
        Calculo calculo = new Calculo();
        
        Console.WriteLine("Digite dois números para somar: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculo.Soma(n1, n2));

        Console.WriteLine("Digite dois números para subtrair: ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        int n4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculo.Subtração(n3, n4));

        Console.WriteLine("Digite dois números para Dividir: ");
        int n5 = Convert.ToInt32(Console.ReadLine());
        int n6 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculo.Divisão(n5, n6));

        Console.WriteLine("Digite dois números para multiplicar: ");
        int n7 = Convert.ToInt32(Console.ReadLine());
        int n8 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculo.Multiplicação(n7, n8));

    }
}
