using System.Security.Principal;
using System.Text;
using MyBank;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть своє ім'я:");
string name = Console.ReadLine().ToString();

Console.WriteLine("Введіть свій баланс: ");
decimal value = Convert.ToInt16(Console.ReadLine());

Account acc = new Account(name, value);

bool isWhile = true;

while (isWhile)
{
    Console.WriteLine("Що бажаєте зробити?");
    Console.WriteLine("1. Положити гроші\n2. Зняти гроші\n3. Показати баланс\n4. КАЗІНОООО\n0. Вийти\n");
    int choice = Convert.ToInt16(Console.ReadLine());
    Console.Clear();
    switch (choice)
    {
        case 0:
            isWhile = false;
            break;
        case 1:
            Console.WriteLine("Яку суму хочете положити?");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            acc.Deposit(deposit);
            break;
        case 2:
            Console.WriteLine("Яку суму хочете положити?");
            decimal withdraw = Convert.ToDecimal(Console.ReadLine());
            acc.WithDraw(withdraw);
            break;
        case 3:
            Console.WriteLine($"На вашому рахунку {acc.ShowBalance()}");
            Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("Яку суму хочете депнути?");
            decimal dep = Convert.ToDecimal(Console.ReadLine());
            acc.Dep(dep);
            break;

    }
}