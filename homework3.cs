//Напишите программу, которая приниматет на вход длину массива, минимальное значение массива и максимальное значение массива, 
//создаёт массив с заданными параметрами и выводит значения на экран.

Console.WriteLine("Введите длину массива: ");
int inputLengthArray = GetIntInput();

Console.WriteLine("Введите min значение массива: ");
int inputMinArray = GetIntInput();

Console.WriteLine("Введите Max значение массива: ");
int inputMaxArray = GetIntInput();
int[] array = new int[inputLengthArray];

GetArray(inputLengthArray, inputMinArray, inputMaxArray);
PrintArray(array);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void GetArray(int length, int min, int max)
{
    for (int i = 0; i < length; i++)
    {
       array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}