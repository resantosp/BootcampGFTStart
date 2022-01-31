using static System.Console;
using AulaReferenceAndValueTypes.Entities;

public class Program
{
    public static int Adicionar20(int a)
    {
        return a + 20;
    }
    public static void DemoValueType()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"Hello, World! O novo valor é {a}.");
    }
    public static void Demo2()
    {
        string nome = "Renata";

        TrocarNome(nome, "Marina");

        System.Console.WriteLine($"Meu novo nome é {nome}");
    }
    public static void Demo3()
    {
        int[] numeros = new int[]{0, 3, 5, 8, 9};

        MudarParaImpar(numeros);

        System.Console.WriteLine($@"
        O próximo nº ímpar relativo a cada um dos valores do array é: 
        {string.Join(", ", numeros)}.");
    }
    public static void Demo4()
    {
        //É possível pedir por ReadLine cada um dos valores que vão formar meu array
        int[] numeros2 = new int[]{0, 2, 4, 6, 8};
        System.Console.WriteLine("Digite o número desejado: ");
        var numero = int.Parse(ReadLine());

        var IndiceEncontrado = EncontrarNumero(numeros2, numero);

        if (IndiceEncontrado == -1)
        {
            System.Console.WriteLine("Número não encontrado no Array.");
        }
        else
        {
            System.Console.WriteLine($"O número foi encontrado no índice {IndiceEncontrado}.");
        }
    }

    public static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }
    public static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }
    static void MudarParaImpar(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            int resto = 0;
            resto = numeros[i] % 2;
            if (resto == 0)
            {
                numeros[i] += 1;
            }
            else
            {
                numeros[i] += 2;
            }
        }
    }
    static int EncontrarNumero(int[] numeros2, int numero)
    {
        for (int i = 0; i < numeros2.Length; i++)
        {
            if (numeros2[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
    static bool EncontarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            //Aqui é importante especificar o valor Nome que está sendo buscado porque na real as duas referências apontam para lugares diferentes na memória, então o que quermos mesmo saber é se o nome de uma é igual ao da outra
            //Ou seja, com Reference Types, para comparar valores temos que especificar as propriedades consultadas
            if (item.Nome == pessoa.Nome)
            {
                return true;
            }
        }

        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Renata"},
            new Pessoa(){Nome = "Mariana"},
            new Pessoa(){Nome = "Alessandra"}
        };

        System.Console.WriteLine("Digite o nome que deseja identificar: ");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var pessoaEncontrada = EncontarPessoa(pessoas, pessoa);

        if (pessoaEncontrada)
        {
            System.Console.WriteLine("Pessoa identificada na lista.");
        }
        else
        {
            System.Console.WriteLine("Pessoa NÃO identificada na lista.");
        }


    }

    

}
