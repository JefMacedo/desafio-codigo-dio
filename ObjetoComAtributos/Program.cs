using System;

class Jogador
{
    private string nome;
    private string nacionalidade;
    private int idade;
    private string posicao;

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
        this.idade = idade;
        this.posicao = posicao;
    }

    public void ExibirInfo()
    {
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(nome);
        Console.WriteLine(nacionalidade);
        Console.WriteLine(idade);
        Console.WriteLine("Posição: " + posicao);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do jogador: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a nacionalidade do jogador: ");
        string nacionalidade = Console.ReadLine();

        Console.Write("Digite a idade do jogador: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite a posição do jogador: ");
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        jogador.ExibirInfo();
    }
}