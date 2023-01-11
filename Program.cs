using System;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY
            // STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY
            // STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY
            // STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY STRATEGY
            
            // Strategy pattern is used when...
            // We have 'multiple' algorithm for a specific task
            // ...and client decides the actual implementation to be used at 'runtime'.
            // ================================================================================
            
            int value1 = 8;
            int value2 = 2;
            int result;

            Context context = new Context();
            char chosenOperator = ' ';

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Välj en operator: ");
                    Console.WriteLine("1: +");
                    Console.WriteLine("2: -");
                    Console.WriteLine("3: *");
                    Console.WriteLine("4: /");
                    Console.WriteLine("0: Exit");

                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input < 1 || input > 4)
                    {
                        break;
                    }

                    switch (input)
                    {
                        case 1:
                            context.SetStrategy(new AdditionStrategy());
                            chosenOperator = '+';
                            break;
                        case 2:
                            context.SetStrategy(new SubtractionStrategy());
                            chosenOperator = '-';
                            break;
                        case 3:
                            context.SetStrategy(new MultiplicationStrategy());
                            chosenOperator = '*';
                            break;
                        case 4:
                            context.SetStrategy(new DivisionStrategy());
                            chosenOperator = '/';
                            break;
                    }

                    result = context.ExecuteStrategy(value1, value2);
                    Console.WriteLine($"{value1} {chosenOperator} {value2} = {result}");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
