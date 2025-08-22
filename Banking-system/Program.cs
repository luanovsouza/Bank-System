using System.Globalization;
using Banking_System.Entities;
using System.IO;

namespace Banking_System;

public class Program
{
    private static int correctPassword = 12345; //Senha correta

    static void Main(string[] args)
    {
        while (true)
        {
            var user = Login(); //‘user’ recebe a função ‘Login()’, ou seja, tudo que tiver na função vai para a variável ‘User’

            if (user != null) //Se a função ‘Login()’ for nula, vai executar até ele não ser mais nulo
            {
                Console.WriteLine($"Bem-Vindo, {user.Name}");
                Menu(user);
                break;
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
            return null; //Aqui esta a verificação se ele for nulo ou não
        }
        //Se não for nulo vai pedir o saldo, e instanciar um novo objeto do tipo ‘Users’
        Console.Write("Qual seu saldo Inicial?: ");
        double initialBalance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.WriteLine();
        
        return new Users(name, passWord, initialBalance, login);
    }

    static void Menu(Users users)
    {
        while (true)
        {
            Console.WriteLine("\n Escolha uma Opção Abaixo:");
            Console.WriteLine("1- Consultar Saldo: ");
            Console.WriteLine("2- Depositar: ");
            Console.WriteLine("3- Sacar: ");
            Console.WriteLine("4- Sair: ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine($"Saldo: {users.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Digite uma quantia para depositar: ");
                    double ammount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    users.Deposit(ammount);
                    Console.WriteLine();
                    break;
            }
        }
    }
}