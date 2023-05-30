public class Emprestimo 
{
    public Livro livro;
    public Pessoa pessoa;
    public DateTime emprestimo;
    public DateTime devoluçao;

    public void EmprestarLivro(Livro livro, Pessoa pessoa, DateTime devoluçao)
    {
        if (livro.status == true)
        {
            this.livro = livro;
            this.pessoa = pessoa;
            this.emprestimo = DateTime.Now;
            this.devoluçao = devoluçao;
            this.livro.status = false;

            Console.WriteLine("O livro foi emprestado");
        }
        else
        {
            Console.WriteLine("Livro indisponível");
        }

    }

    public void DevolverLivro(Livro livro, Pessoa pessoa, DateTime devoluçao)
    {
        this.livro = livro;
        this.pessoa = pessoa;
        this.emprestimo = DateTime.Now;
        this.devoluçao = devoluçao;
        this.livro.status = false;

        Console.WriteLine("O livro foi devolvido");
    }
}


