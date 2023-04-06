//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int inputNum = GetIntInput();
int result = GetSumDigit(inputNum);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int GetSumDigit(int a)
{
    int i = 0;
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a%10;
        a /= 10;
        i++;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {inputNum} = {result}");