double amount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double rateForMonth = (amount * (annualInterestRate / 100)) / 12;
double totalAmmount = amount + months * rateForMonth;

Console.WriteLine($"{totalAmmount}");

