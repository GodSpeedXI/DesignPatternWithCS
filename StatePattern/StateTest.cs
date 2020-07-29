using System;
using DesignPatternPractice.StatePattern.AbusingStatePattern;

namespace DesignPatternPractice.StatePattern
{
    public static class StateTest
    {
        public static void Testing()
        {
            var desService = new DirectionService();
            desService.SetCurrentDestination(new DirectToBKK());
            DisplayDirection(desService);

            desService.SetCurrentDestination(new DirectToHKT());
            DisplayDirection(desService);

            var abusingState = new StopWatch();
            abusingState.SetCurrentState(new RunningState(abusingState));
            Console.WriteLine("StopWatch State: {0}", abusingState.GetCurrentState());

            abusingState.SetCurrentState(new StopState(abusingState));
            Console.WriteLine("StopWatch State: {0}", abusingState.GetCurrentState());

            abusingState.SetCurrentState(new RunningState(abusingState));
            Console.WriteLine("StopWatch State: {0}", abusingState.GetCurrentState());

        }

        private static void DisplayDirection(DirectionService service)
        {
            Console.WriteLine("Destination: {0} \n Direction: {1} \n ETA: {2} Min",
                service.GetDestination(), service.GetDirection(), service.GetETA());
            Hr();
        }

        private static void Hr()
        {
            Console.WriteLine("-----");
        }
    }
}
