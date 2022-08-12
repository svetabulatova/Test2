//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число");
int num1=Convert.ToInt32 (Console.ReadLine());
int num2=num1%7;
int num3=num1%23;
if(num2==0 & num3==0)
{
    Console.WriteLine("Данное число кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine ("Данное число не кратно 7 и 23 одновременно");
}