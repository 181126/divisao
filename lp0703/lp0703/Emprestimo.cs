public class Emprestimo
{
    public Livro livro;
    public Pessoa pessoa;
    public DateTime emprestimo;
    public DateTime devolucao;

    public void EmprestarLivro(Livro livro, Pessoa pessoa, DateTime devolucao)
    {
        if (livro.status == true)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            this.emprestimo = DateTime.Now;
            this.devolucao = devolucao;
            this.livro.status = false;

            Console.WriteLine("Livro emprestado");
        }
        else
        {
            Console.WriteLine("Livro indisponível");
        }

    }

    public void DevolverLivro(Livro livro, Pessoa pessoa)
    {

        if (livro.status == false)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            this.devolucao = DateTime.Now;
            this.livro.status = true;

            Console.WriteLine("Livro devolvido com sucesso ");
        }
        else
        {
            Console.WriteLine("Livro já disponível");
        }
        
    }
}
