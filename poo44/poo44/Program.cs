using System;
class poo
{
    static void Main(string[] args)
    {
        Alunos pessoa = new Alunos();
        pessoa.nome = "Renato";
        pessoa.email = "renato@gmail.com";
        pessoa.nota1 = 7.8;
        pessoa.nota2 = 5.7;
        Console.WriteLine("A média de "+ pessoa.nome + "titular do email "+ pessoa.email + "é igual a: " + pessoa.Media());






    }
}
