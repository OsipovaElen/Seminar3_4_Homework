//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число A: ");
int inputA = GetIntInput();
int getA = inputA;
Console.WriteLine("Введите число A: ");
int inputB = GetIntInput();

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

for (int i = 1; i < inputB; i++)
{
    inputA = inputA * inputA; 
}

Console.WriteLine($"{getA} в степени {inputB} = {inputA}");