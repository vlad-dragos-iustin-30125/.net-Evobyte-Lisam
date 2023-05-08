using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Park
    {
        public string Name { get; set; } 
        public int NumberOfBenches { get; set; }
        public void AddPlayGround()
        {
            Console.WriteLine("A play ground has been added to the park");

        }
    }
}
