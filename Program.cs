using System;
class Program
{
    static void Main(string[] args)
    {
    Console.Write(value: "Введите фамилию: ");
    string surname = Console.ReadLine();

    Console.Write("Введите желаемую оценку: ");
    string grade = Console.ReadLine();

    Console.WriteLine($"Поздравляю, {surname}! У Вас автоматом {grade} за экзамен.");
    }
}
    
