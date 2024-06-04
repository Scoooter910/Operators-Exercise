namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var sum = a + b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

            Console.WriteLine($"{a}/{b} is {Divide(a, b)} remainder {Modulus(a, b)}");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

        public static int Divide(int num1, int num2)
        { return num1 / num2; }

        public static int Modulus(int num1, int num2)
        { return num1 % num2; }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;

        }

    }
        
}
