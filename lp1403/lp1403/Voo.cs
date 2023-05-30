using System.Reflection.Metadata.Ecma335;

public class Voo
{
    private DateTime dataHora;
    private int nVoo;
    public bool [] cadeiras = new bool[10];
    
    public Voo(int nVoo, DateTime dataHora)
    {
        this.dataHora = dataHora;   
        this.nVoo = nVoo;

    }
    public int GetVoo(int nVoo)
    {
        return this.nVoo = nVoo;
    }
    public void setVoo(int nVoo)
    {
        this.nVoo = nVoo;
    }
    public DateTime getDataHora()
    {
        return this.dataHora;   
    }
    public void setDataHora(DateTime dataHora)
    {
        this.dataHora = dataHora;
    }
    public DateTime GetData(DateTime dataHora)
    {
        return this.dataHora = dataHora;
    }
    public int ProximoLivre()
    {
        for (int i = 0; i < cadeiras.Length; i++)
        {
            if (this.cadeiras[i] == false)
            {
                return i;
                break;
            }
           
        }
        Console.WriteLine("Não há cadeiras livres");
        return -1;
    }
    public bool Ocupar(int nCadeira)
    {
        if (this.cadeiras[nCadeira] == false)
        {
            this.cadeiras[nCadeira] = true;
            return true;
        }
        else
        {
            Console.WriteLine("Cadeira já está ocupada! ");
            return false;
        }
    } 
    public bool Verificar(int nCadeira)
    {
        if (this.cadeiras[nCadeira] == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int Vagas()
    {
        int cont = 0;
        for(int i = 0; i < this.cadeiras.Length; i++)
        {
            if (this.cadeiras[i] == false)
            {
                cont += 1;
            }
        }
        return cont;
    }
}