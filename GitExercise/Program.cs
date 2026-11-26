namespace GitExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string operation;
            double res;
            Console.WriteLine("-------------------------------------------- КАЛЬКУЛЯТОР --------------------------------------------\n");
            while (true)
            {
                Console.WriteLine("Num1 : "); num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Num2 : "); num2 = double.Parse(Console.ReadLine());
              

                Console.WriteLine("Choose operation");
                operation = Console.ReadLine();

                if (operation == "+")
                {
                    res = num1 + num2;
                    Console.WriteLine($"Result = {res}");
                }
                else if (operation == "-")
                {
                    res = num1 - num2;
                    Console.WriteLine($"Result = {res}");
                }
                else if (operation == "*")
                {
                    res = num1 * num2;
                    Console.WriteLine($"Result = {res}");
                }
                else if (operation == "/")
                {
                    res = num1 / num2;
                    Console.WriteLine($"Result = {res}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
