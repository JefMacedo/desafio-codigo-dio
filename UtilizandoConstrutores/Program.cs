using System;

class Personagem
{
    private string nome;
    private string raca;
    private string classe;
    private int nivel;
    private int vida;

    public Personagem(string nome, string raca, string classe)
    {
        this.nome = nome;
        this.raca = raca;
        this.classe = classe;
        this.nivel = 1;
        this.vida = 10;
    }
    
    public void ExibirStatus()
    {
        Console.WriteLine($"Status: \nNome:{nome} \nRaça:{raca} \nClasse:{classe} \nNível:{nivel} \nVida:{vida}");
    }
}

class Program
{
    static void Main()
    {
        string entradaNome = Console.ReadLine();
        string entradaRaca = Console.ReadLine();
        string entradaClasse = Console.ReadLine();

        Personagem personagem = new Personagem(entradaNome, entradaRaca, entradaClasse);

        personagem.ExibirStatus();
    }
}