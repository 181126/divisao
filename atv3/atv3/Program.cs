public class Program
{
    static void Main(string[] args)
    {
        Calculo conversao = new Calculo();  
        
        Console.WriteLine("Digite o número de horas para converter: ");
        int horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(conversao.Hm(horas));

        Console.WriteLine("Digite o número de minutos para converter: ");
        int minutos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(conversao.Ms(minutos));

        Console.WriteLine("Digite o número de segundos para converter: ");
        int segundos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(conversao.Sh(segundos));

    }
}
