using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Box
    {
        public String ProductOrder { get; set; }
        public String PartNumber { get; set; }
        public String SerialNumber { get; set; }
        public String TrayNumber { get; set; }
        public String TrayUnit { get; set; }

        public Box(string productOrder, string partNumber, string serialNumber, string trayNumber, string trayUnit)
        {
            ProductOrder = productOrder;
            PartNumber = partNumber;
            SerialNumber = serialNumber;
            TrayNumber = trayNumber;
            TrayUnit = trayUnit;
        }
    }
}
