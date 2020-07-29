namespace DesignPatternPractice.StatePattern
{
    public class DirectToBKK : IDestination
    {
        public string Direction()
        {
            return "North";
        }

        public int ETA()
        {
            return 60;
        }
    }
}
