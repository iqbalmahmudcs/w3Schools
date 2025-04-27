//To return a value by a method you should premitive data type( such as int / double / string) instead of void
//and use the return keyword.inside the method
Console.WriteLine(MyMethod(10));
Display(10);
int y = MyMethod(5);
Console.WriteLine(y);


static int MyMethod(int x)
{
    return 10 + x;
}

static void Display(int x)
{
    Console.WriteLine(MyMethod(x));
}





