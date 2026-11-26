namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию:");
            char sim = char.Parse(Console.ReadLine());

            switch (sim)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    if (b == 0) break;
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    break;
            }
        }
    }
}
