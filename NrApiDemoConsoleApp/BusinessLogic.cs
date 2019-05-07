using NewRelic.Api.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NrApiDemoConsoleApp
{
    public class BusinessLogic
    {
        [Transaction]
        public void DoSomething(int i)
        {
            NewRelic.Api.Agent.NewRelic.AddCustomParameter("CustomDiscountCode", "DISCO"+i);
            Thread.Sleep(2000);
            Console.WriteLine("Expected logging from customer app, run=" + i);
            execute();
        }

        [Trace]
        private void execute()
        {
            Thread.Sleep(200);
        }
    }
}
