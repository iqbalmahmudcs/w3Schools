// Sort a string
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars);

foreach(string car in cars)
    Console.WriteLine(car);


// Sort an int
int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);

foreach(int number in myNumbers)
    Console.WriteLine(number);



//System.Linq Namespace
//Other useful array methods, such as Min, Max, Sum, can be found in the Sya=stem.Linq namespace

Console.WriteLine(myNumbers.Min());
Console.WriteLine(myNumbers.Max());
Console.WriteLine(myNumbers.Sum());


