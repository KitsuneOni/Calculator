using Calculator.Classes;

namespace Calculator
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            //Console.WriteLine("Work");
            Console.Clear();
            Console.WriteLine("Press 1 to enter Addition");
            Console.WriteLine("Press 2 to enter Subtraction");
            Console.WriteLine("Press 3 to enter Multiplication");
            Console.WriteLine("Press 4 to enter Exit");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int option))
            {
                if (option != 1 && option != 2 && option != 3 && option != 4) 
                {
                    option = 0;
                }
                
            }
            else
            {
                option = 0;
            }

            switch (option)
            {
                case 1:
                    AddMenu();
                    break;
                case 2:
                    SubtractMenu();
                    break;
                case 3:
                    MultiplicationMenu();
                    break;
                case 4:
                    Console.WriteLine("ByeBye");
                    break;
                case 0:
                    Console.WriteLine("AGAIN");
                    MainMenu();
                    break;
            }
        }

        private static void AddMenu()
        {
            CalculatorOverride calc = new CalculatorOverride();
            Console.Clear();
            Console.WriteLine("Addition");
            
            Console.WriteLine("Please enter first number:");

            string numOneInput = Console.ReadLine();
            
            if (!int.TryParse(numOneInput, out int num1))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                AddMenu();
            }
            
            Console.WriteLine("Please enter second number:");

            string numTwoInput = Console.ReadLine();
            
            if (!int.TryParse(numTwoInput, out int num2))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                AddMenu();
            }
            
            Console.Clear();
            Console.WriteLine(calc.Add(num1, num2));
            Thread.Sleep(2000);
            MainMenu();
        }

        private static void SubtractMenu()
        {
            CalculatorOverride calc = new CalculatorOverride();
            Console.Clear();
            Console.WriteLine("Subtraction");
            
            Console.WriteLine("Please enter first number:");

            string numOneInput = Console.ReadLine();
            
            if (!int.TryParse(numOneInput, out int num1))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                SubtractMenu();
            }
            
            Console.WriteLine("Please enter second number:");

            string numTwoInput = Console.ReadLine();
            
            if (!int.TryParse(numTwoInput, out int num2))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                SubtractMenu();
            }
            
            Console.Clear();
            Console.WriteLine(calc.Sub(num1, num2));
            Thread.Sleep(2000);
            MainMenu();
        }
        
        private static void MultiplicationMenu()
        {
            CalculatorOverride calc = new CalculatorOverride();
            Console.Clear();
            Console.WriteLine("Multiplication");
            
            Console.WriteLine("Please enter first number:");

            string numOneInput = Console.ReadLine();
            
            if (!int.TryParse(numOneInput, out int num1))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                MultiplicationMenu();
            }
            
            Console.WriteLine("Please enter second number:");

            string numTwoInput = Console.ReadLine();
            
            if (!int.TryParse(numTwoInput, out int num2))
            {
                Console.WriteLine("Try again");
                Thread.Sleep(2000);
                MultiplicationMenu();
            }
            
            Console.Clear();
            Console.WriteLine(calc.Mult(num1, num2));
            Thread.Sleep(2000);
            MainMenu();
        }
    }
}