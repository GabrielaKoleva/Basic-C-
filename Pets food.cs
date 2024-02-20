int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double priceDogFood = dogFood * 2.50;
double priceCatFood = catFood * 4;

double allPrice = priceDogFood + priceCatFood;

Console.WriteLine($"{allPrice:F2} lv.");
