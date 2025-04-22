// You can access the carecters in string by refering to its index number inside square brackets[]
string myString = "Hello World!";
Console.WriteLine($"{myString[3]}");

// You can also find index position of a specific charecter in a string, by using the IndexOf() method.
Console.WriteLine($"{myString.IndexOf("l")}");

// Substring() which extract  the charecters from a string. This method is often used together with IndexOf() to get the specific character position
string name = "Iqbal Mahmud";
int charecterPosition = name.IndexOf("M");
string lastName = name.Substring(charecterPosition);
Console.WriteLine(lastName);

