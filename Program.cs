
class Programa
{
    static void Main()
    {
        // TODO: Lista
        List<string> names = new List<string> { "Guilherme", "Gabriel", "Gustavo" };

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
    }
}

class Teste
{
    public int X;
}

// TODO: Exemplo de construtor de classe.
class BankAccount
{
    private string? name;
    private decimal? value;

    // TODO: Exemplo de metodo construtor.
    // O construtor deve ter o mesmo nome da Classe
    public BankAccount(string name, decimal value)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Nome Inválido");
        }
        if (value < 0)
        {
            throw new Exception("Saldo negativo");
        }
        this.name = name;
        this.value = value;
    }

    public void AddMoney()
    {

    }
}