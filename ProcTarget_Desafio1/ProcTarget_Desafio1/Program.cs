namespace ProcTarget_Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int targetNumber = int.TryParse(Console.ReadLine().Trim(), out int result) ? result : 0;

            if (FibonacciHasTargetNumber(targetNumber))
                Console.WriteLine("\nO número escolhido, '{0}', pertence à sequência de Fibonacci!", targetNumber);
            else
                Console.WriteLine("\nO número escolhido, '{0}', NÃO pertence à sequência de Fibonacci.", targetNumber);

        }

        static bool FibonacciHasTargetNumber(int targetNumber)
        {
            int previousValue = 0, nextValue = 1;
            for (int currentValue = 0; currentValue < targetNumber; currentValue = previousValue)
            {
                previousValue = nextValue;
                nextValue += currentValue;
            }
            return targetNumber == previousValue;
        }
    }
}
