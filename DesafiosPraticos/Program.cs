using System;

public class Problem 
{
    static void Desafio1()
    {
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes) 
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Digite um número válido de 1 a 12");
                break;
        }
        Console.ReadLine();
    }
    static void Desafio2()
    {
        int n = int.Parse(Console.ReadLine());

        int inicio = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{Math.Pow(inicio, 1)} {Math.Pow(inicio, 2)} {Math.Pow(inicio, 3)}");
                inicio += 1;
        }
    }
    static void Desafio3()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int soma = 0;
        
        while (x != 0)
        {
            for (int i = 0; i < 5; i++)
            {
                if (x % 2 == 0)
                {
                    soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                }
                if (x % 2 != 0)
                {
                    x += 1;
                    soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                }
            }
            System.Console.WriteLine($"{soma}");
            x = Convert.ToInt32(Console.ReadLine());
        }
    }
    public static void Main() 
    {
        
        
    }
}