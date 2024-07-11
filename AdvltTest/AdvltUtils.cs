namespace AdvltTest
{
    public static class AdvltUtils
    {
        public static int CalcStepsToEquilibrium(IEnumerable<int> playerChips)
        {
            int[] equlibratedPlayerChips = playerChips.ToArray();
            int totalSteps = 0;
            int maxChipsIndex = 0;
            int minChipsIndex = 0;

            do
            {
                for (int i = 0; i < equlibratedPlayerChips.Length; i++)
                {
                    if (equlibratedPlayerChips[i] > equlibratedPlayerChips[maxChipsIndex])
                    {
                        maxChipsIndex = i;
                    }
                    if (equlibratedPlayerChips[i] < equlibratedPlayerChips[minChipsIndex])
                    {
                        minChipsIndex = i;
                    }
                }

                int leftMinChipsIndex = maxChipsIndex - 1;
                if (leftMinChipsIndex < 0)
                {
                    leftMinChipsIndex = minChipsIndex;
                }

                int rightMinChipsIndex = maxChipsIndex + 1;
                if (rightMinChipsIndex > equlibratedPlayerChips.Length - 1)
                {
                    rightMinChipsIndex = minChipsIndex;
                }

                int minNeighborChipsIndex = equlibratedPlayerChips[leftMinChipsIndex] < equlibratedPlayerChips[rightMinChipsIndex]
                    ? leftMinChipsIndex : rightMinChipsIndex;

                if (equlibratedPlayerChips[maxChipsIndex] > equlibratedPlayerChips[minNeighborChipsIndex])
                {
                    equlibratedPlayerChips[minNeighborChipsIndex]++;
                    equlibratedPlayerChips[maxChipsIndex]--;
                    totalSteps++;
                }
            } while (equlibratedPlayerChips[maxChipsIndex] != equlibratedPlayerChips[minChipsIndex]);

            return totalSteps;
        }
    }
}