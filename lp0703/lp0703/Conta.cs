public class Conta
{
    private double saldototal;

    public double GetSaldoTotal()
    {
        return this.saldototal;
    }
    public void SetSaldoTotal(double saldototal)
    {
        if (saldototal >= 0) { this.saldototal = saldototal; }

        else
        {
            Console.WriteLine("Valor inválido");
        }
    }
}