using System;

class Personagem
{
    protected string nome;
    protected int mana;

    public Personagem(string nome, int mana)
    {
        this.nome = nome;
        this.mana = mana;
    }
}

class Subclasse : Personagem
{
    private int danoBase;

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        this.danoBase = danoBase;
    }

    public int CalcularDano(int quantidadeMana)
    {
        return danoBase * quantidadeMana;
    }

    public void Atacar(int quantidadeMana)
    {
        int danoCausado = CalcularDano(quantidadeMana);
        Console.WriteLine($"{nome} atacou e causou {danoCausado} de dano!");
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int mana = int.Parse(Console.ReadLine());
        int danoBase = int.Parse(Console.ReadLine());
        Subclasse sc = new Subclasse(nome, mana, danoBase);
        sc.Atacar(mana);
    }
}
