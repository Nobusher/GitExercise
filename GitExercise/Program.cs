namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            double result;

            if (op == "+")
                result = a + b;
            else if (op == "-")
                result = a - b;
            else if (op == "*")
                result = a * b;
            else if (op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: делить на нуль низя");
                    return;
                }
                result = a / b;
            }
            else
            {
                Console.WriteLine("Нема такой операции");
                return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
