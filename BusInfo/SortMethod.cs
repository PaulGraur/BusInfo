using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public interface SortMethod
    {
        public List<BusRoute> SortByDestination();
        public List<BusRoute> SortByTime();
    }
}
