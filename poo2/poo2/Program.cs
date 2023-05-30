using System;
class poo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de horas para converter: ");
        int horas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(horas * 60);

        Console.WriteLine("Digite o número de minutos para converter: ");
        int minutos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(minutos * 60);

        Console.WriteLine("Digite o número de horas para converter: ");
        int segundos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(segundos / 3600);

        Console.ReadKey();
    }
}