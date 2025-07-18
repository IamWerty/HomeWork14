using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank
{
    public class Account
    {
        public string Name { get; }
        private decimal balance;

        public Account(string name, decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new Exception("Баланс не може бути меньше 0.");
            }

            Name = name;
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Ви не можете поповнювати на міносуву суму.");
            }

            balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Сума повинна бути більшою за 0.");
            }
            if (amount > balance)
            {
                throw new Exception("Недостатньо коштів на рахунку.");
            }

            balance -= amount;
        }

        public decimal ShowBalance()
        {
            return balance;
        }

        public void Dep(decimal amount)
        {
            if (amount > balance)
            {
                throw new Exception("Не можна заложити більше, ніж у вас є.");
            }
            Random rnd = new Random();
            decimal depCash = -amount + Convert.ToDecimal(rnd.NextDouble()) * (amount + amount);
            balance += depCash;
        }
    }
}