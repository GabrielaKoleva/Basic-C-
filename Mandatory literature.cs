int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int hoursForReeding = numberOfPages / pagesPerHour;
int hoursPerDay = hoursForReeding / numberOfDays;

Console.WriteLine($"{hoursPerDay}");
