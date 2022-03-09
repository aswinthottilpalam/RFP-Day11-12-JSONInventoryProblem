using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONinventoryManagement
{
    public class RiceClass
    {
        public String Name { get; set; }
        public double Weight { get; set; }
        public double PricePerKg { get; set; }
    }

    public class PulsesClass
    {
        public String Name { get; set; }
        public double Weight { get; set; }
        public double PricePerKg { get; set; }
    }

    public class WheatClass
    {
        public String Name { get; set; }
        public double Weight { get; set; }
        public double PricePerKg { get; set; }
    }

    public class InventoryModel
    {
        public List<RiceClass> RiceList { get; set; }
        public List<WheatClass> WheatList { get; set; }
        public List<PulsesClass> PulsesList { get; set; }
    }
}
