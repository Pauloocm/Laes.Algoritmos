namespace Laes.SegundaEtapa
{
    public static class IsAFizzBuzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            List<string> output = [];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output.Add("FizzBuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    output.Add("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    output.Add("Buzz");
                    continue;
                }

                output.Add(i.ToString());
            }

            if ((output.Any(s => s.Length % 3 == 0) && (output.Any(s => s.Length % 5 == 0))))
                return output = ["i"];

            return output;
        }
    }
}
