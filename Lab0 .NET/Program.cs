namespace Lab0_.NET
{

    internal class FizzBuzz
    {
        private int upperLim;

        public FizzBuzz(int upperLim)
        {
            this.upperLim = upperLim;
        }

        public void PrintNum()
        {
            for(int i = 1; i <= upperLim; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = 20;
            FizzBuzz fizz_buzz = new FizzBuzz(range);
            fizz_buzz.PrintNum();
        }
    }
}
