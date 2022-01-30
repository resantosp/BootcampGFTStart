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
    public static void Main()
    {
        //É possível pedir por ReadLine cada um dos valores que vão formar meu array
        int[] numeros = new int[]{0, 3, 5, 8, 9};

        MudarParaImpar(numeros);

        System.Console.WriteLine($@"
        O próximo nº ímpar relativo a cada um dos valores do array é: 
        {string.Join(", ", numeros)}.");

    }

    

}
