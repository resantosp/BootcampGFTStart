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

    public static void TrocarNome(Pessoa p1, string novoNome)
    {
        p1.Nome = novoNome;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Renata";
        p1.Idade = 25;
        p1.Documento = "01";
        
        System.Console.WriteLine($"Nome original: {p1.Nome}");

        string novoNome = Console.ReadLine();
        
        TrocarNome(p1, novoNome);

         System.Console.WriteLine($"Nome trocado: {p1.Nome}");

    }
}