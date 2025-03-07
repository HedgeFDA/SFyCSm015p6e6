using System;
using System.Collections.Generic;
using System.Linq;

namespace SFyCSm015p6e6;

class Program
{
    /// <summary>
    /// Функция собирающая учеников всех классов в один список
    /// </summary>
    /// <param name="classes">Массив классных комнат</param>
    /// <returns>Массив всех учеников</returns>
    static string[] GetAllStudents(Classroom[] classes)
    {
        return classes.SelectMany(c => c.Students).ToArray();
    }

    /// <summary>
    /// Процедура реализующая основной алгоритм работы приложения.
    /// </summary>
    static void PerformMain()
    {
        var classes = new[]
        {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
        
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }

    /// <summary>
    /// Главная точка входа приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки при запуске приложения.</param>
    static void Main(string[] args)
    {
        PerformMain();
    }
}