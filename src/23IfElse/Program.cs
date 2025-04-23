int myAge = 26;
int votingAge = 18;

//Use the if statement to specify a block of C# code to be executed if a condition is True.
if (myAge >= votingAge)
    Console.WriteLine("You are a voter");



int time = 20;

//Use the else statement to specify a block of code to be executed if the condition is False.
if (time < 18)
    Console.WriteLine("Good Day!");
else
    Console.WriteLine("Good Evening!");


//Use the else if statement to specify a new condition if the first condition is False.
if(time < 10)
    Console.WriteLine("Good Morning");
else if(time < 20)
    Console.WriteLine("Good Day");
else
    Console.WriteLine("Good Evening");


//If...Else (Ternary Operator)
// Syntax: variable = (condition) ? expressionTrue :  expressionFalse;
string result = (time < 18) ? "Good Day" : "Good Evening";
Console.WriteLine(result);






