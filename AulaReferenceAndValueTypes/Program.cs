﻿using static System.Console;

public class Program
{
    public static int Adicionar20(int a)
        {
            return a + 20;
        }
    public static void Main()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"Hello, World! O novo valor é {a}.");
    }
}