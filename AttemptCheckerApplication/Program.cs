using System;

namespace AttemptCheckerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          try{
                var attemptChecker = new AttempCheckerLib.AttemptChecker();
                Console.WriteLine("Please inform a number between 0 and 100");
                var checkResult= attemptChecker.CheckNumber(int.Parse(Console.ReadLine()));
                Console.WriteLine(checkResult);
                awaitClose(attemptChecker);
                while (!attemptChecker.MaxAttemptsReached())
                    {
                        Console.WriteLine("Please inform a number between 0 and 100");
                        var attemptResult = attemptChecker.CheckNumber(int.Parse(Console.ReadLine()));
                        Console.WriteLine(attemptResult);

                        awaitClose(attemptChecker);

                    }

            } catch (FormatException ex) {
                Console.WriteLine($"Error: only numbers allowed - {ex.Message}");
            }

        }
        

        private static void awaitClose(AttempCheckerLib.AttemptChecker attemptChecker)
        {
            if (attemptChecker.IsSuccess())
            {
               Environment.Exit(-1);
            }
        }
    }
}
