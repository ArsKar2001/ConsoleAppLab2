// ReSharper disable All

using System;
using System.Linq;
using static System.Console;

namespace ConsoleAppLab2
{
    public static class LabTwo
    {
        public static void Execution(string task)
        {
            switch (task)
            {
                case "1":
                    LabTwo.ExecutionTask1();
                    break;
                case "2":
                    LabTwo.ExecutionTask2();
                    break;
                case "3":
                    LabTwo.ExecutionTask3();
                    break;
                case "4":
                    LabTwo.ExecutionTask4();
                    break;
                default:
                    WriteLine($"Ошибка: неизвестная команда: {task}");
                    break;
            }
        }

        /// <summary>
        /// Дано 10 вещественных чисел: a1,a2,...,a10. Требуется найти порядковый номер того из них, которое наиболее близко к какому-нибудь целому числу.
        /// </summary>
        public static void ExecutionTask1()
        {
            WriteLine("Дано 10 вещественных чисел: a1,a2,...,a10. " +
                      "Требуется найти порядковый номер того из них, которое наиболее близко к какому-нибудь целому числу.");

            double[] aa = new double[10];
            for (int i = 0; i < aa.Length; i++)
            {
                Write($"Введите число a{i + 1}: ");
                aa[i] = Convert.ToDouble(ReadLine());
            }

            double[] ar = new double[10];
            for (var i = 0; i < aa.Length; i++) ar[i] = Math.Abs(Math.Round(aa[i]) - aa[i]);

            int id = 0;
            double min_value = ar[id];
            for (var i = 1; i < ar.Length; i++)
            {
                if (ar[i] < min_value)
                {
                    id = i;
                    min_value = ar[id];
                }
            }

            WriteLine(
                $"Порядковый номер наиболее близкого к целому числу: {id + 1}. {aa[id]} -> {Math.Round(aa[id])}");
        }

        /// <summary>
        /// Написать программу, которая вычисляет сумму первых N целых положительных чисел.
        /// </summary>
        public static void ExecutionTask2()
        {
            WriteLine("Написать программу, которая вычисляет сумму первых N целых положительных чисел.");
            Write("Введите число N: ");

            int n = Convert.ToInt32(ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            WriteLine($"Сумма первых {n} целых положительных чисел: {sum}");
        }

        /// <summary>
        /// Рассмотреть указанную последовательность в цикле и выйти из цикла,
        /// достигнув указанного условия с выдачей порядкового номера члена,
        /// при котором достигнуто условие. Если же за m оборотов цикла условие не достигнуто,
        /// напечатать об этом сообщение.
        /// 
        /// </summary>
        public static void ExecutionTask3()
        {
            WriteLine(
                "Рассмотреть указанную последовательность в цикле и выйти из цикла, " +
                "достигнув указанного условия с выдачей порядкового номера члена, при котором достигнуто условие. " +
                "Если же за m оборотов цикла условие не достигнуто, напечатать об этом сообщение.");
            Write("Введите кол-во оборотов цикла: ");
            int m = Convert.ToInt32(ReadLine());

            double an = 1;
            int n = 1;
            while (Math.Abs(an) > 0.1)
            {
                if (n < m)
                {
                    double f = Factorial(n);
                    an = 1d / Math.Pow(f, 1d / n);
                    an = Math.Round(an, 3);
                    WriteLine($"a{n} = {an}");
                    n++;
                }
                else
                {
                    WriteLine($"Условие не достигнуто за {m} оборотов цикла.");
                    return;
                }
            }

            WriteLine($"Условие достигнуто за оборотов цикла {n - 1}: {Math.Abs(an)} < 0.1");
        }

        public static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static void ExecutionTask4()
        {
        }
    }
}