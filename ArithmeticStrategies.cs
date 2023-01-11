namespace StrategyDemo
{
    public class AdditionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }

    public class SubtractionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }

    public class MultiplicationStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }

    public class DivisionStrategy : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a / b;
        }
    }
}
