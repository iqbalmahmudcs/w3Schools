using System.Net.Sockets;

int intNumber = 55;    //Stores whole numbers from -2,147,483,648 to 2,147,483,647
long longNumber = 4654654654564654654L;    //Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float floatNumber = 101.11F;    //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double doubleNumber = 1.1D;      //Stores fractional numbers. Sufficient for storing 15 decimal digits
bool boolValue = true;    //only true / false can store
char charValue = 'C';    //Stores a single character/letter, surrounded by single quotes
string stringValue = "C sharp is awesome!";    //Stores a sequence of characters, surrounded by double quotes

Console.WriteLine(intNumber);
Console.WriteLine(longNumber);
Console.WriteLine(floatNumber);
Console.WriteLine(doubleNumber);
Console.WriteLine(boolValue);
Console.WriteLine(charValue);
Console.WriteLine(stringValue);