//The "Write / WriteLine" Methodes is used for Display variables which is a method of Console class is a class of System namespace.

using System.Runtime.ExceptionServices;

string name = "Iqbal";
Console.WriteLine(name); //displaying a variable
Console.WriteLine(name + " Hassan");    //displaying a variables and concatenate another word.

//You can also use the + character to add a variable to another variable:
string firstName = "Iqbal";
string middleName = "Hassan";
string lastName = "Mahmud";
Console.WriteLine(firstName + " " + middleName + " " + lastName);

//For numeric value + caharecter works as a mathametical operator:
int num1 = 5;
int num2 = 4;
Console.WriteLine(num1 + num2);    //output is 9

int sum = num1 + num2;
Console.WriteLine(sum);