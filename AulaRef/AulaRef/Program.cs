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
    static void Demo2()
    {
       var nomes = new string[]{"Renata", "Mariana", "Ricardo"};

       System.Console.WriteLine($@"A lista de nomes ATUAL é:
       {string.Join(", ", nomes)}");

       System.Console.Write("Digite o nome a ser substituído: ");
       string nomeAntigo = Console.ReadLine().Trim();

       System.Console.Write("Digite o nome a ser incluído: ");
       string nomeNovo = Console.ReadLine().Trim();

       //TrocarNome(nomes, nomeNovo, nomeAntigo);

       System.Console.WriteLine();
       System.Console.WriteLine($@"A lista de nomes ALTERADA é:
       {string.Join(", ", nomes)}");

    }
    static void Demo3()
    {
        var nomes = new string[]{"Renata", "Mariana", "Ricardo"};

       System.Console.WriteLine($@"A lista de nomes ATUAL é:
       {string.Join(", ", nomes)}
       ");

       System.Console.Write("Digite o nome a ser substituído: ");
       string nomeAntigo = Console.ReadLine().Trim();

       int indice = LocalizarNome(nomes, nomeAntigo);

       if (indice == -1)
       {
           System.Console.WriteLine("\nNome não encontrado na lista.");
       }
       else
       {
           System.Console.Write("Digite o nome a ser incluído: ");
           string nomeNovo = Console.ReadLine().Trim();
           
           nomes[indice] = nomeNovo;
           
           System.Console.WriteLine();
           System.Console.WriteLine($@"A lista de nomes ALTERADA é:
           {string.Join(", ", nomes)}");
       }
    }
    static int LocalizarNome(string[] nomes, string nomeAntigo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeAntigo)
            {
                return i;
            }
        }
        //Como usei um if, precisa dar um return aqui fora também para caso não encontre o nome
        return -1;
        
    }
    static void TrocarNome(string[] nomes, string nomeNovo, int indice)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomes[indice])
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Main()
    {
       
       

    }
}