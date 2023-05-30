public class Program
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        c.SetSaldoTotal(-1);

        Conta c2 = new Conta();
        c2.SetSaldoTotal(10);
        Console.WriteLine(c2.GetSaldoTotal());
    }
}
