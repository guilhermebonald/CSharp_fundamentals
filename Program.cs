﻿
class Programa
{
    static void Main()
    {
        // TODO: Lista
        List<string> names = new List<string> { "Joao", "Marcos", "Lucas" };
        // * ou
        List<string> names1 = new List<string>();
        // add to list
        names1.Add("Joao");
        // remove
        names1.Remove("Joao");

        // TODO: For 
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        // TODO: For Each
        foreach (string item in names)
        {
            Console.WriteLine(item);
        }

        // TODO: Operações com String
        string name = "Guilherme";
        Console.WriteLine(name.Length); // Tamanho
        Console.WriteLine(name.EndsWith("me")); // Termina com...
        Console.WriteLine(name.StartsWith("Gui")); // Inicia com...
        Console.WriteLine(name.Contains("Gui")); // Contem...
        Console.WriteLine(name.IndexOf("u")); // Indice de...
        Console.WriteLine(string.IsNullOrWhiteSpace(name)); // É vazio ou tem espaços em branco.
        Console.WriteLine(string.Join(" ", names)); // Junta uma lista de strings
        Console.WriteLine(10.ToString()); // Converte não só Int, mas qualquer tipo para String

        // TODO: Conversão de STRING > INT
        int x = int.Parse("10");
        Console.WriteLine(x.GetType());
        int.TryParse("10", out int z);
        Console.WriteLine(z.GetType());

        // TODO: Referenciando Classes.
        Teste t = new Teste();
        t.X = 10;
        Console.WriteLine(t.X);

        // TODO: Declaração NULL
        //Variáveis de valor (como int, double, bool) não podem ser null a menos que sejam declaradas como nullable usando o operador ?.
        // Declarando uma variável de referência como null
        string? minhaString = null;

        // Declarando uma variável nullable como null
        int? meuInteiro = null;
        Console.WriteLine($"minhaString: {minhaString}, meuInteiro: {meuInteiro}");

        // TODO: BankAccount Set
        ConsoleLogger logger = new ConsoleLogger();
        BankAccount account1 = new BankAccount("Mateus", 100, logger);
        BankAccount account2 = new BankAccount("Marcos", 250, logger);

        account1.Deposit(-100);
        account2.Deposit(50);

        Console.WriteLine($"Balanço da Conta: {account1.GetBalance()}");
        Console.WriteLine($"Balanço da Conta: {account2.GetBalance()}");

        // TODO: Delegate/Lambda Expression
        var multiply = (int x, int y) => x * y;
        var sum = delegate (int x, int y) { return x + y; };

        // Declarando o tipo
        // O último tipo é o que será retornado, e os primeiros o que será passado como argumento.
        Func<int, int, int> subtract = delegate (int x, int y) { return x - y; };

    }
}

class Teste
{
    // usar o public permite que eu altere a variavel de fora da Classe, o que pode ser perigoso.
    public int X;
}

class BankAccount
{
    // usar o private ou deixar sem nada, assegura de que a variavel de construtor seja usada apenas pelo construtor ou internamente.
    // TODO: Variavel de Instancia
    private string name;
    private decimal balance;
    private ILogger logger;

    // TODO: Metodo Construtor.
    // * O construtor deve ter o mesmo nome da Classe
    public BankAccount(string name, decimal balance, ILogger logger)
    {
        // this. faz referencia a variavel de instancia.
        this.name = name;
        this.balance = balance;
        this.logger = logger;
    }

    public void Deposit(Decimal amount)
    {
        if (amount < 0)
        {
            logger.Log($"Não é possivel adicionar {amount} para {this.name}");
        }
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

// TODO: Interfaces
interface ILogger
{
    void Log(string message);
}

// TODO: Classe que implementar a Interface
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logger Interface: {message}");
    }
}