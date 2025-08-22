using System.Globalization;
using Banking_System.Entities;

namespace Banking_System;

public class Program
{
    static void Main(string[] args)
    {
        int passwordcorrect = 12345;
        
        
        Console.Write("Digite seu nome: ");
        string? name = Console.ReadLine();

        Console.Write("Digite seu login: ");
        string? login = Console.ReadLine();

        Console.Write("Digite a sua senha para entrar: ");
        int passWord = int.Parse(Console.ReadLine()!);

        Console.Write("Qual seu saldo Inicial?: ");
        double initialBalance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (login != null) new Users(name, passWord, initialBalance, login);

        while (true)
        {
            if (passWord == passwordcorrect)
            {
                
            }
            else
            {
                continue;
            }
        }
    }
}