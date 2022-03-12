//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine((number == 0) || (reverse(number, 0) == number));

int reverse(int number, int i)

{
    while (number > 0)
    {
        i = i * 10 + number % 10; number /= 10;
        
    }

    return i;
}