using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInfo
{
    public abstract class FileOperation
    {
        public abstract void SaveScheduleToFile(string filePath);
        public abstract List<BusRoute> LoadScheduleFromFile(string filePathw);
    }
}
