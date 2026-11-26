using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.Write("Введите первое число: ");
                if (double.TryParse(Console.ReadLine(), out double first)) ;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }

                Console.Write("Введите второе число: ");
                if (double.TryParse(Console.ReadLine(), out double second)) ;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы ввели не число");
                    continue;
                }

                Console.Write("Введите оперант: ");
                string? op = Console.ReadLine();

                Console.Clear();
                Calculate(first, op, second);
            }

        }
        static void Calculate(double first, string op, double second)
        {

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                    
                case "-":
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                    
                case "*":
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
                    
                case "/":
                    if (second == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        break;
                    }
                    Console.WriteLine($"{first} / {second} = {first / second}");
                    break;

                default: 
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }
    }
}
