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
        static void Main(string[] args)
        {
            Console.WriteLine("Player chips:");
            string inputString = Console.ReadLine() ?? throw new NullReferenceException();
            string[] stringValues = inputString.Replace(" ", "").Split(',');
            
            int[] playerChips = new int[stringValues.Length];
            for (int i = 0; i < stringValues.Length; i++)
            {
                playerChips[i] = Convert.ToInt32(stringValues[i]);
            }

            Console.WriteLine($"Total steps: {AdvltUtils.CalcStepsToEquilibrium(playerChips)}");
        }
    }
}