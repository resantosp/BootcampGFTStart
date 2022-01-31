using static System.Console;

class AulaRef
{
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    static void Main()
    {
        int a = 5; 
        Adicionar20(ref a);

        System.Console.WriteLine(a); 
    }
}