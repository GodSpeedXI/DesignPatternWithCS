using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternPractice.ObserverPattern
{
    public static class ObserverPatternTest
    {
        public static void Run()
        {
            var ssTk = new SpreadSheetTracker();
            var ssRpt1 = new SpreadSheetReporter("FirstInst");
            ssRpt1.Subscribe(ssTk);

            var ssRpt2 = new SpreadSheetReporter("SecondInst");
            ssRpt2.Subscribe(ssTk);

            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet1", DateTime.Now));
            Thread.Sleep(1000);
            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet2", DateTime.Now));
            Thread.Sleep(1000);
            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet3", DateTime.Now));
            Thread.Sleep(1000);
            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet4", DateTime.Now));
            Thread.Sleep(1000);
            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet5", DateTime.Now));
            ssTk.EndTransmission();
            Thread.Sleep(1000);
            ssTk.TrackSpreadSheet(new SpreadSheetModel("Sheet6", DateTime.Now));
        }
    }
}
