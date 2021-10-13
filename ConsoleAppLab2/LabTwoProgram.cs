using System;
using static System.Console;

namespace ConsoleAppLab2
{
    internal static class LabTwoProgram
    {
        private static void Main(string[] args)
        {
            ExecutionLabTwo();
        }

        private static void ExecutionLabTwo()
        {
            WriteLine("Лабораторная работа 2.");
            WriteLine("Цикл с параметром, цикл - Пока.");

            while (true)
            {
                WriteLine("Введите номер задания:\n" +
                          "\t1. 5.9\n" +
                          "\t2. 5.14\n" +
                          "\t3. 6.9");
                var task = ReadLine();
                LabTwo.Execution(task);
            }
        }
    }
}