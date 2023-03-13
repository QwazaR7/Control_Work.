string[] NewStringArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ArrayShow (string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

}

string[] ModifiedArray(string[] array)
{
    string[] modArray = new string[array.Length];
    int count = 0;
    int i = 0;
    while(count< array.Length)
    {
        if(array[count].Length <= 3)
        {
            modArray[i] = array[count];
            count++;
            i++;
        }
        else count++;
    }
    return modArray;
}
Console.Write("Укажите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] newArr = NewStringArray(length);
string[] modArr = ModifiedArray(newArr);
ArrayShow(modArr);