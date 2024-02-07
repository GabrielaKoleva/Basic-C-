string firstName = Console.ReadLine();
string LastName = Console.ReadLine();
string email = Console.ReadLine();
Console.WriteLine("Customer: "+ firstName + " " 
    + LastName + " " + "(" + email +")");

Console.WriteLine($"Customer: {firstName} " +
    $"{LastName} ({email}");
