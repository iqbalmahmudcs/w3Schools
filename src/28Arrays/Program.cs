//Arrays are used to store multiple values in a single variable, instead of declearing separae=te variables for each value.

//Declare and assign value of an array
string[] cars = { "Volvo", "BMW", "Ford", "Mazda"};
int[] myNumber = { 1, 2, 3};


//Access the elements of an array by reffering the index number
Console.WriteLine(cars[0]);
Console.WriteLine(myNumber[1]);


//Change an array element
cars[3] = "Hondai";
Console.WriteLine(cars[3]);


//Array Length
int arrayLenth = cars.Length;
Console.WriteLine(arrayLenth);


//Create an array of four elements, and add values later
string[] name = new string[4];

//Create an array of four elements and add values right away
string[] car = new string[4] { "Volvo", "BMW", "Fodrd", "Mazda" };

// Create an array of four elements without specifying the size 
string[] bus = new string[] { "Volvo", "BMW", "Ford", "Mazda" };



