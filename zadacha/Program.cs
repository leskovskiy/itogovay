
string[] array = {"57484", "world", "1", "puk"};
string[] NewArray = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[count] = array[i];
        count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(NewArray);