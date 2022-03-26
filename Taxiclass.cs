using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Taxiclass
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }
        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName:{0}", DriverName);
            Console.WriteLine("OnDuty:{0}", OnDuty);
            Console.WriteLine("NumPassenger:{0}", NumPassenger);

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
           
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
    }
}
