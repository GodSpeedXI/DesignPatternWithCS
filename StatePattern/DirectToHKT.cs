namespace DesignPatternPractice.StatePattern
{
    public class DirectToHKT : IDestination
    {
        public string Direction()
        {
            return "South";
        }

        public int ETA()
        {
            return 120;
        }
    }
}
