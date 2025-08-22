using Banking_System.Exceptions;

namespace Banking_System.Entities;

public class Users
{
    public string? Name { get; set; }
    public string? Login { get; set; }
    public int PassWord { get; set; }
    public double Balance { get; set; }

    public Users()
    {
    }

    public Users(string? name, int passWord, double initialBalance, string login)
    {
        Name = name;
        PassWord = passWord;
        Balance = initialBalance;
        Login = login;
    }

    public void Deposit(double ammount)
    {
        if (ammount == 0.0)
        {
            throw new UsersExceptions("A quantia nao pode ser 0!");
        }
        
        Balance += ammount;
    }

    public void WithDraw(double ammount)
    {
        if (Balance == 0.0)
        {
            throw new UsersExceptions("Não pode sacar com saldo zerado!");
        }
        
        if (ammount > Balance)
        {
            throw new UsersExceptions("Não pode sacar se a quantia for maior que o saldo!");
        }

        Balance -= ammount;
    }
}