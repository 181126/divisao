using System;
class Poo
{
	static void Main(string[] args)
	{
		try 
		{
            Console.Write("informe um numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("informe outro numero: ");
            int b = int.Parse(Console.ReadLine());
            int result = a / b;
            Console.WriteLine(result);
        } 
         catch(Exception e)
        {
            Console.WriteLine("!!");
        }
        
       	
	} 
}

