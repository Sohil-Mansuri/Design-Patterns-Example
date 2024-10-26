using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface IFilter
    {
        void Apply(Image image);
    }

    public class Image
    {

    }
}
