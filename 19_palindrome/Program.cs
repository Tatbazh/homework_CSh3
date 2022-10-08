// Задача 19. входные данные - 5-тизначное число, 
//выводные - является ли число палиндромом
void Palindrome(int N)
{
    int resultend = N % 100;
    int resultstart = N / 1000;
    if (resultend % 10 == resultstart / 10 && resultend / 10 == resultstart % 10)
{
    Console.Write($"{N} - это число палиндром");
}
else
{
    Console.Write($"{N} - это число НЕ палиндром");
}
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
Palindrome(number);