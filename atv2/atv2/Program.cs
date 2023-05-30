public class Program
{
    static void Main(string[] args)
    {

        Operações contas = new Operações();
        Console.Write("Digite dois numeros para se somarem: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(contas.Adiçao(n1, n2));

        Console.Write("Digite dois numeros para se subtraírem: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        double n4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(contas.Subtraçao(n3, n4));

        Console.Write("Digite dois numeros para se multiplicarem: ");
        double n5 = Convert.ToDouble(Console.ReadLine());
        double n6 = Convert.ToDouble(Console.ReadLine());
        Console.Write(contas.Multiplicaçao(n5, n6));

        Console.Write("Digite dois numeros para se dividirem: ");
        double n7 = Convert.ToDouble(Console.ReadLine());
        double n8 = Convert.ToDouble(Console.ReadLine());
        Console.Write(contas.Divisao(n7, n8));
    }
}
