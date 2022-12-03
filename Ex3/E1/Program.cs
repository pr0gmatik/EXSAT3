﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num/10000>5){
  Console.WriteLine($"{num} Вы ввели число более 5 символов");
}
else if (num/1000<5){
  Console.WriteLine($"{num} Вы ввели число менее 5 символов");
}
else if (num/10000==num%10 || num/1000==num%100){
  Console.WriteLine($"{num} Введенное Вами число является ПАЛИНДРОМОМ");
}
else {

Console.WriteLine($"{num} Введенное Вами число НЕ ПАЛИНДРОМОМ");
}