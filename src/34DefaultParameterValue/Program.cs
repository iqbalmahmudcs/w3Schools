// you can use a default parameter value, by using the equals(=) sign

MyMethod("Bangladesh");
MyMethod("Pakistan");
MyMethod();    //Result: Norway
MyMethod("China");

static void MyMethod(string countryName = "Norway")
{
    Console.WriteLine(countryName);
}