//The break statement is used for jump out of a loop
for(int i = 0; i< 10; i++)
{
    Console.WriteLine(i);
    if (i == 5)
        break;
}


//The continue statement breaks one cycle of loop, if specified condition occours, and continues with the next cycle of loop.
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("pre" + i);
    if (i == 5)
        continue;
    Console.WriteLine(i);
}


//break in while loop
int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
    if (j == 4)
    {
        break;
    }
}


//continue in while loopsss
j = 0;
while (j < 10)
{
    if (j == 4)
    {
        j++;
        continue;
    }
    Console.WriteLine(j);
    j++;
}



