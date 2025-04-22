/*
 * Type casting is when assign a value of one data type to onother data type.
 * 
 * There are two types of Type Casting:
 * Implicit Casting: char -> int -> long -> float -> double
 * Explicit Casting: double -> float -> long -> int -> char
 */

//Implicit Casting
Console.WriteLine("=====Implicit Casting=====");
char myChar = 'C';
int myInt = myChar;
long myLong = myInt;
float myFloat = myLong;
float myDouble = myFloat;

Console.WriteLine(myChar);
Console.WriteLine(myInt);
Console.WriteLine(myLong);
Console.WriteLine(myFloat);
Console.WriteLine(myDouble);


//Explicit Casting
Console.WriteLine("=====Explicit Casting=====");
myFloat = myDouble;
myLong = Convert.ToInt32(myFloat);
myInt = Convert.ToInt32(myLong);
myChar = Convert.ToChar(myInt);

Console.WriteLine(myDouble);
Console.WriteLine(myFloat);
Console.WriteLine(myLong);
Console.WriteLine(myInt);
Console.WriteLine(myChar);