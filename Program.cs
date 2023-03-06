//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//int ShowSecondDigit (int num)
//{
//int sot = num / 100;
//int ed = num % 10;
//return  (num -( sot * 100) - ed ) /10; 
//}

//int randomnum = new Random().Next(100 , 1000);

//Console.WriteLine(randomnum);
//Console.WriteLine(ShowSecondDigit(randomnum));

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645-> 5

//78 -> третьей цифры нет

//32679 -> 6


// int ShowLastThirdDigit(int num)

// {
//     if (num > 99)
//     {
//         int sot = num / 100;

//         int ed = sot % 10;
//         return ed;
//     }
//     else System.Console.WriteLine("no third digit");
//     return num;
// }
// int randomnum = new Random().Next(1, 100000);

// //int result = ShowLastThirdDigit(randomnum);
// Console.WriteLine(randomnum);
// Console.WriteLine(ShowLastThirdDigit(randomnum));








//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.Write("Hello , Please Input number: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    System.Console.WriteLine($"number {num} is weekend");
}
else if (num <= 5 && num >= 1)
{
    System.Console.WriteLine($"number {num} is not weekend");
}
else
{
    System.Console.WriteLine($"number {num} is not correct ");
}