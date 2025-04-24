//The while loop loops through a block of code as long as specified condition is true

int i = 1;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine();

//The Do/While Loop
//The Ddo/while loop is a variant of the while loop. THus loop will execute the code block onece before checking the conditions
i = 1;
do
{
    Console.WriteLine(i);
    i++;
}
while (i < 1);


//Note: Don't forgot  to increase the variable used in the condition, otherwose the loop will never end!
