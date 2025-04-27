// Informations can be passed as parameter. Parameters act as variables inside the method.

MyMethod("Iqbal", 1);
MyMethod("Asik", 1);
MyMethod("Komolesh", 2);
MyMethod("Mahmud", 1);



static void MyMethod(string fName, int religion)
{
    if(religion == 1)
    {
        Console.WriteLine("Md. " + fName);
    }
    else
        Console.WriteLine(fName);
}









