namespace AdvltTest
{
    public static class AdvltUtils
    {
        public static int CalcStepsToEquilibrium(IEnumerable<int> playerChips)
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
    }
}