using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class BasicTest: ProcessHandler { }
    class ElectricianTest : ProcessHandler { }
    class MechanicTest : ProcessHandler { }
    class ExpertTest : ProcessHandler { }
    abstract class ProcessHandler
    {
        const int MinTestResult = 3;
        ProcessHandler _Next;

        public void SetNext(ProcessHandler next)
        {
            _Next = next;
        }

        public void HandleRequest( Vehicle car)
        {
            Random rnd = new Random();
            int testResult = rnd.Next(10);

            if(testResult <= MinTestResult)
            {
                car.MalfunctionStatus = true;
                car.MalfunctionDesc = $"{this.GetType().FullName} malfuction";
            }
            else
            {
                car.MalfunctionStatus = false;
                if(_Next != null)
                {
                    _Next.HandleRequest(car);
                }
            }
        }
        
    }
}
