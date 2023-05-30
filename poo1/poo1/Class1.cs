public class Conta
{
    public string nomeCliente;
    public string tipoConta;
    public double saldototal;

    public void Depositar(double valor)
    {
        if (valor > 0) 
        {
            saldototal += valor;
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
        
    }

    public void Sacar(double valor)
    {
       if (valor <= saldototal)
        {
            saldototal -= valor;    
        }
        else
        {
            Console.WriteLine("Saque não permitido");
        }
    }

}
