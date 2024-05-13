namespace Calculator.Classes
{
    public class CalculatorOverride : BaseCalculator
    {
        public override int Add(int a, int b)
        {
            Console.WriteLine("Child");

            int addResult = 0;

            addResult = a + b;
            
            return (addResult);
        }
        
        public override int Sub(int a, int b)
        {
            Console.WriteLine("Child");

            int subResult = 0;
            
            subResult = a - b;
            
            return subResult;
        }

        public override int Mult(int a, int b)
        {
            Console.WriteLine("Child");

            int mulResult = 0;
                
            mulResult = a * b;
            
            return mulResult;
        }
    }
}

