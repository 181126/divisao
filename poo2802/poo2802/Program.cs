public class Program
{
    static void Main(string[] args)
    {
        Juros cálculo = new Juros();
  
        Console.Write("Digite um valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.Write("Agora digite a porcentagem que deseja calcular: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O valor do juros é: " + cálculo.CalcularJuros(valor, porcentagem));
        Console.WriteLine("Então o valor total ficou: " + (valor + cálculo.CalcularJuros(valor, porcentagem)));
        


    }


}