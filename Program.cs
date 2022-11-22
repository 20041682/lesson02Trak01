// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("Start");
int value = 862;

int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result = b;
Console.WriteLine (result); 
Console.WriteLine ("End");

