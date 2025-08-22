using System.Globalization;
using Banking_System.Entities;
using System.IO;

namespace Banking_System;

public class Program
{
    static void Main(string[] args)
    {
        int passwordcorrect = 12345;
        
        while (true)
        {
            Console.Write("Digite seu nome: ");
            string? name = Console.ReadLine();

            Console.Write("Digite seu login: ");
            string? login = Console.ReadLine();

            Console.Write("Digite a sua senha para entrar: ");
            int passWord = int.Parse(Console.ReadLine()!);

            Console.Write("Qual seu saldo Inicial?: ");
            double initialBalance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            if (passWord != passwordcorrect)
            {
                Console.WriteLine("Senha incorreta, tente Novamente!");
                Console.WriteLine();
            }
            else
            {
                Users users =  new Users(name, passWord, initialBalance, login);
                
                try
                {
                    
                }
                catch (IOException e)
                {
                    Console.WriteLine("Um erro ocorreu!");
                    Console.WriteLine($"ERRO: {e.Message}");
                    throw;
                }
                break;
            }
        }
        

    }
}