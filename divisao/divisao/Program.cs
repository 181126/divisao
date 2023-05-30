using System;
class Poo
{
	static void Main(string[] args)
	{
        Console.WriteLine("informe um numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("informe outro numero: ");
        int b = int.Parse(Console.ReadLine());
		int result = a / b;
		Console.WriteLine(result);	
	} 
}

