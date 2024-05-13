namespace Calculator.Classes 
{
    public abstract class BaseCalculator
    {
        public virtual int Add(int a, int b)
        {
            int addResult = 0;

            addResult = a + b;
            
            return (addResult);
        }
        public virtual int Sub(int a, int b)
        {
            int subResult = 0;
            
            subResult = a - b;
            
            return subResult;
        }
        public virtual int Mult(int a, int b)
        {
            int mulResult = 0;
                
            mulResult = a * b;
            
            return mulResult;
        }
    }
    
}