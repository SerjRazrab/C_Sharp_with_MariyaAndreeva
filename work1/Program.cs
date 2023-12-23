// Напишите программу которая принимает на вход два целых числа и проверяет,является ли первое число квадратом второго.
int a = 36;
int b = 6;

if(b*b==a)
    Console.WriteLine("Yes");
else
    Console.WriteLine("no");

// Способ собирания данных с консоли
Console.Write( " Enter a number: " );
string str1 = Console.Readline()!;

int num1 = int.parse(str1);