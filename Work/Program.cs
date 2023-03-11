string[] NewStringArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку массива:\t");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ArrayShow (string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

}
Console.Write("Укажите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] newArr = NewStringArray(length);
ArrayShow(newArr);