class Poo
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        Console.WriteLine("Digite seu nome: ");
        c.nomeCliente = Console.ReadLine();
        c.tipoConta = "Corrente";
        c.saldototal = 0;

        Console.WriteLine("Informe o valor do depósito");
        double valor = Convert.ToDouble(Console.ReadLine());    

        c.Depositar(valor);
        Console.WriteLine($"O saldo total após o depósito é {c.saldototal}");
        
        Console.WriteLine("Informe o valor do saque");
        double valor2 = Convert.ToDouble(Console.ReadLine());
       
        c.Sacar(valor2);
        Console.WriteLine($"O saldo total após o saque é {c.saldototal}");
    }
}
