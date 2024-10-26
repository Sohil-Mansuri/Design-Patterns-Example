using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class CamelThirdParyFilter
    {
        public void Init()
        {
            Console.WriteLine("connection set up");
        }

        public void Process(Image image)
        {
            Console.WriteLine("Applying camle filter");
        }
    }
}
