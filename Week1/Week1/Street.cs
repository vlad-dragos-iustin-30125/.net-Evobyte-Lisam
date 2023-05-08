using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Street
    {
        public string Name { get; set; }
        public int SpeedLimit { get; set; }
        public void AddTrafficLight()
        {
            Console.WriteLine("A traffic light has been added to the street.");
        }
    }
}
