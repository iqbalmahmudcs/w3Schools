// When you already knows that how many times you want to loop through a block of code, use the for loop instead of a while loop.

using System.Runtime.CompilerServices;

for (int i = 0; i< 10; i++)
    Console.WriteLine(i);

//Nested Loops
//It is also possible to place a loop inside another loop. This is called nested loop
//The inner Loop is executed for each cycle of outer loop

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("This is outer loop");
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine(j);
    }
}



//Foreach Loop
//There is also a foreach loop which is used exclusively to loop through elements in an array or an other data set

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

foreach(string i in cars)
    Console.WriteLine(i);








