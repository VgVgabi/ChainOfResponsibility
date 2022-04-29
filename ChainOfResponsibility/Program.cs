using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Annual inspection of the vehicle");
            Vehicle car1 = new Vehicle(){ Model = "BMW M4 Competition" };
            BasicTest bt = new BasicTest();
            ElectricianTest et = new ElectricianTest();
            MechanicTest mt = new MechanicTest();
            ExpertTest expTest = new ExpertTest();
            Console.WriteLine("The Chain Of Responsibility");
            bt.HandleRequest(car1);

            if(car1.MalfunctionStatus)
                Console.WriteLine($"{car1.Model} {car1.MalfunctionDesc}");
            else
                Console.WriteLine($"{car1.Model} Passed All Tests");
        }
    }
}