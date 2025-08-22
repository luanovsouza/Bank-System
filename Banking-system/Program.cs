using System.Globalization;
using Banking_System.Entities;
using System.IO;

namespace Banking_System;

public class Program
{
    private static int correctPassword = 12345;

    static void Main(string[] args)
    {
        while (true)
        {
            var user = Login();

            if (user != null)
            {
                Console.WriteLine($"Bem-Vindo, {user.Name}");
            }
        }
    }

    static Users? Login()
    {
        Console.Write("Digite seu nome: ");
        string? name = Console.ReadLine();

        Console.Write("Digite seu login: ");
        string? login = Console.ReadLine();

        Console.Write("Digite a sua senha para entrar: ");
        int passWord = int.Parse(Console.ReadLine()!);

        if (passWord != correctPassword)
        {
            Console.WriteLine("Senha incorreta, tente Novamente! \n");
            return null;
        }
        Console.Write("Qual seu saldo Inicial?: ");
        double initialBalance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        
        return new Users(name, passWord, initialBalance, login);
    }
}