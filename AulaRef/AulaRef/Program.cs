using static System.Console;

class AulaRef
{
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    static void Demo1()
    {
         int a = 5; 
        Adicionar20(ref a);

        System.Console.WriteLine(a); 
    }
    static void TrocarNome(string[] nomes, string nomeNovo, string nomeAntigo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeAntigo)
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Main()
    {
       var nomes = new string[]{"Renata", "Mariana", "Ricardo"};

       System.Console.WriteLine($@"A lista de nomes ATUAL é:
       {string.Join(", ", nomes)}");

       System.Console.Write("Digite o nome a ser substituído: ");
       string nomeAntigo = Console.ReadLine().Trim();

       System.Console.Write("Digite o nome a ser incluído: ");
       string nomeNovo = Console.ReadLine().Trim();

       TrocarNome(nomes, nomeNovo, nomeAntigo);

       System.Console.WriteLine($@"A lista de nomes ALTERADA é:
       {string.Join(", ", nomes)}");

    }
}