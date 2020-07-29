namespace DesignPatternPractice.StatePattern
{
    /// <summary>
    /// StatePattern is a design pattern used for changing state of the object with
    /// open close principle (open for extensibility and close for modifiability)
    /// This class is designed as Context
    /// </summary>
    public class DirectionService
    {
        private IDestination _destination;
        public int GetETA()
        {
            return _destination.ETA();
        }

        public string GetDirection()
        {
            return _destination.Direction();
        }

        public void SetCurrentDestination(IDestination destination)
        {
            _destination = destination;
        }

        public IDestination GetDestination()
        {
            return _destination;
        }
    }
}
