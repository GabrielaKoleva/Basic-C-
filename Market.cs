double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double allTomato = tomatoPrice * tomatoQuantity;
double allCucumber = cucumberPrice * cucumberQuantity;

double total = allTomato + allCucumber;

Console.WriteLine($"{total:F2}");
