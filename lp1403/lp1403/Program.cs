public class Program
{
	static void Main(string[] args)
    {
        Voo voo = new Voo(01, DateTime.Now);
        Console.Write("Deseja explorar as opções do menu (digite 1 para sim ou 2 para não)? ");
        int resposta = Convert.ToInt32(Console.ReadLine());

        while (resposta == 1)
        {
            
              Console.WriteLine("Escolha uma das opções do menu abaixo" + "\n 1- Retornar o número da próxima poltrona livre"
              + "\n 2- Verificar se uma poltrona específica está ocupada" + "\n 3- Ocupar uma poltrona caso esteja livre"
              + "\n 4- Retornar o número de cadeiras livres");
              int opcao = Convert.ToInt32(Console.ReadLine());  
            
            if (opcao == 1)
            {
                voo.ProximoLivre();

            }
            else if (opcao == 2)
            {
                voo.Verificar();
            }
            else if (opcao == 3)
            {
                voo.Ocupar();
            }
            else if (opcao == 4)
            {
                voo.Vagas();
            }
            else
            {
                Console.WriteLine("opção inválida");
            }
        }
    }
}