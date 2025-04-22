String firstName = "Iqbal ";
string middleName = "Hassan ";
string LastName = "Mahmud ";

// The  + operator is used to concatinate two or more strings
Console.WriteLine($"Full Name: {firstName + " " + middleName + " " + LastName}");

//we can use string.Concat() method to concatinate multiple string
Console.WriteLine($"{string.Concat(firstName, middleName, LastName)}");