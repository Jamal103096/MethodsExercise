namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Whats is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand =  Console.ReadLine();
            
            Console.WriteLine($"One day, {userName} was walking through the woods while wearing {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}.");
            
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number; 
                sum += number;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            //MadLib();
            //Console.WriteLine(Add(numOne: 2, numTwo: 2));
            //Console.WriteLine(Subtract(numOne: 2, numTwo: 2));
            //Console.WriteLine(Multiply(2,2));
            //Console.WriteLine(Divide(2,2));
            Console.WriteLine(Sum( 5, 4, 3, 2, 1));


        }
    }
}
