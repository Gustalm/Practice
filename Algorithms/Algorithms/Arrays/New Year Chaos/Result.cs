using System.Collections.Generic;

namespace Algorithms.Arrays.New_Year_Chaos
{
    public static class Result
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void minimumBribes(List<int> q)
        {
            var maxBribeCount = 0;
            var totalBribes = 0;
            for (int i = 0; i < q.Count; i++)
            {
                var ticketNumber = q[i];
                var positionChanges = ticketNumber - (i + 1);
                
                if (positionChanges > 0)
                    totalBribes += positionChanges;

                if (positionChanges > 2)
                {
                    System.Console.WriteLine("Too chaotic");
                    break;
                }
            }

            System.Console.WriteLine(totalBribes);
        }
    }
}
