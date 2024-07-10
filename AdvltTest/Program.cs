namespace AdvltTest
{
    /**
     * Jose set up a circular poker table for his friends so that each of the seats at the table has the same number of poker chips.
     * But when Jose wasn’t looking, someone rearranged all of the chips so that they are no longer evenly distributed!
     * Now Jose needs to redistribute the chips so that every seat has the same number before his friends arrive.
     * But Jose is very meticulous: to ensure that he doesn’t lose any chips in the process, he only moves chips between adjacent seats.
     * Moreover, he only moves chips one at a time. What is the minimum number of chip moves
     * Jose will need to make to bring the chips back to equilibrium?
     */

    public class Program
    {
        private static int CalcStepsToEquilibrium(IEnumerable<int> playerChips)
        {
            int[] equlibratedPlayerChips = playerChips.ToArray();
            int totalSteps = 0;
            bool isFinished = false;
            int maxChipsIndex = 0;

            do
            {
                for (int i = 0; i < equlibratedPlayerChips.Length; i++)
                {
                    if (equlibratedPlayerChips[i] > equlibratedPlayerChips[maxChipsIndex])
                    {
                        maxChipsIndex = i;
                    }
                }

                int leftMinChipsIndex = maxChipsIndex - 1;
                if (leftMinChipsIndex < 0)
                {
                    leftMinChipsIndex = equlibratedPlayerChips.Length - 1;
                }

                int rightMinChipsIndex = maxChipsIndex + 1;
                if (rightMinChipsIndex > equlibratedPlayerChips.Length - 1)
                {
                    rightMinChipsIndex = 0;
                }

                int minChipsIndex = equlibratedPlayerChips[leftMinChipsIndex] < equlibratedPlayerChips[rightMinChipsIndex]
                    ? leftMinChipsIndex : rightMinChipsIndex;

                if (equlibratedPlayerChips[minChipsIndex] == equlibratedPlayerChips[maxChipsIndex])
                {
                    isFinished = true;
                }
                else
                {
                    equlibratedPlayerChips[minChipsIndex]++;
                    equlibratedPlayerChips[maxChipsIndex]--;
                    totalSteps++;
                }
            } while (!isFinished);

            return totalSteps;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Player count: ");
            int playerCount = Convert.ToInt32(Console.ReadLine());

            int[] playerChips = new int[playerCount];
            for (int i = 0; i < playerChips.Length; i++)
            {
                Console.WriteLine($"Chip count for player {i + 1}: ");
                playerChips[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Total steps: {CalcStepsToEquilibrium(playerChips)}");
        }
    }
}