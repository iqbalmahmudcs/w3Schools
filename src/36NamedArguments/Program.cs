//It is also posible to send arguments with the key value syntax
//That way the order of the argument does not matter


MyMethod(child3: "Mahmud", child1: "Iqbal", child2: "Hassan");

static void MyMethod(string child1, string child2, string child3)
{
    Console.WriteLine($"Child 1 = {child1} \nChild 2 = {child2} \nChild 3 = {child3}");
}