public class Lp
{
    static void Main(string[] args)
    {

        Livro l = new Livro("abc", "Renato", "2023", true, 01);
        Pessoa p = new Pessoa("Renato", "222.333.333.55", "renato.gmail.com");

        Emprestimo emprestimo = new Emprestimo();

        emprestimo.EmprestarLivro(l, p, new DateTime(2023, 03, 13));

        emprestimo.DevolverLivro(l, p, new DateTime(2023, 03, 07));

    }
}
