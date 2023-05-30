
public class Livro
{
    public string titulo;
    public string nomeAutor;
    public string anoLançamento;
    public bool status;
    public int CodId;
    public Livro (string titulo, string nomeAutor, string anoLançamento, bool status, int CodId)
    {
        this.titulo = titulo;
        this.nomeAutor = nomeAutor;
        this.anoLançamento = anoLançamento;
        this.status = status;
        this.CodId = CodId;
    }   
}
