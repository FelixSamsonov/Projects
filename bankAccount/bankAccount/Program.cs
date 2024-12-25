using System;

namespace bankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount myBankAccount = new BankAccount();
            Console.Write($"Вітаю! Для створення банківського рахунку потрібно ініціалізуватися та поповнити рахунок. \nІВведіть ваше призвіще та ім'я: ");
            myBankAccount.NameOfAccount = Console.ReadLine();
            Console.WriteLine($"На вашому рахунку '{myBankAccount.NameOfAccount}' наразі: {myBankAccount.Balance} грн.");
            Console.WriteLine("Для активації банківського акаунту, його треба поповнити на суму від 1000 грн.");
            while (true)
            {
                Console.Write("Ведіть суму першого поповнення: ");
                if (int.TryParse(Console.ReadLine(), out int firstDeposit))
                {
                    if (firstDeposit >= 1000)
                    {
                        myBankAccount.Deposit(firstDeposit);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Сума поповнення має бути від 1000 грн");
                        continue;
                    }
                }
                else
                    Console.WriteLine("Введене не коректне значення!!!");
            }

            while (true)
            {
                Console.WriteLine("\nОберіть дію: \n'1' - Поповнити рахунок\n'2' - Зняти кошти\n'3' - Вийти");
                string operation = Console.ReadLine();

                if (operation == "3")
                {
                    Console.WriteLine("Дякуємо за використання банківської системи. До побачення!");
                    break;
                }

                myBankAccount.ChangeOperation(operation);
            }
        }
    }

    public class BankAccount
    {
        public string NameOfAccount { get; set; }
        private decimal balance;
        public decimal Balance => balance;

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Рахунок поповнено на {amount} грн, сума на рахунку складає {balance} грн.");
            }
            else
                Console.WriteLine("Сума поповнення має бути більше 0.");
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Ви зняли {amount} грн, залишок на рахунку: {balance} грн.");
            }
            else
                Console.WriteLine($"Грошей на рахунку недостатньо для зняття {amount} грн, залишок: {balance} грн.");
        }

        public void ChangeOperation(string operation)
        {
            switch (operation)
            {
                case "1":
                    Console.Write("Введіть суму, на яку хочете поповнити рахунок: ");
                    if (int.TryParse(Console.ReadLine(), out int depositAmount))
                    {
                        this.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Введена некоректна сума.");
                    }
                    break;

                case "2":
                    Console.Write("Введіть суму, яку хочете зняти: ");
                    if (int.TryParse(Console.ReadLine(), out int withdrawAmount))
                    {
                        this.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Введена некоректна сума.");
                    }
                    break;

                default:
                    Console.WriteLine("Вибрана некоректна дія.");
                    break;
            }
        }
    }
}
