//Multidimentional array is basically an array of arrays.

int[,] numbers = { { 1, 1, 1 }, { 2, 2, 2} };
Console.Write(numbers[0, 0]);    //Result: 2
Console.Write(numbers[0, 1]);
Console.WriteLine(numbers[0, 2]);
Console.Write(numbers[1, 0]);
Console.Write(numbers[1, 1]);
Console.Write(numbers[1, 2]);
Console.WriteLine();

//Access all the elements
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write(numbers[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

//change elements of an 2D array
numbers[1, 2] = 5;
Console.WriteLine();















