using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrApiDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic bl = new BusinessLogic();
            for (int i=0; i < 1000; i++)
            {
                bl.DoSomething(i);
            }
        }
    }
}
