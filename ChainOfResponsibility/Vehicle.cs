using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Vehicle
    {
        public string Model { get; set; }
        public bool MalfunctionStatus { get; set; }
        public string MalfunctionDesc { get; set; }
    }
}
